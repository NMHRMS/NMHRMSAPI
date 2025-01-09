using Application.Dtos.Auth;
using Application.Interfaces.Auth;
using AutoMapper;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static Domain.Enums.Enums;

namespace Application.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;
        private readonly IPasswordHelper passwordHelper;

        public AuthService(IRepository repository, IMapper mapper, IPasswordHelper passwordHelper)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.passwordHelper = passwordHelper;
        }

        #region Puublic Methods
        public void SignUp(SignUpDto signUpDto)
        {
            var isDuplicate = CheckDuplicate(signUpDto);

            if (isDuplicate)
                throw new ArgumentException("Company Already Exists");

            var currentDate = DateTime.Now;
            var companyDetails = mapper.Map<Company>(signUpDto);
            companyDetails.CreateDate = currentDate;
            repository.Add(companyDetails);

            var profileDetails = new Domain.Models.Profile();
            profileDetails.Profile1 = ProfileTypes.Admin.ToString();
            profileDetails.IsAdmin = true;
            profileDetails.CreateDate = currentDate;
            profileDetails.CompanyId = companyDetails.CompanyId;
            profileDetails.CreateLoginId = 0;
            repository.Add(profileDetails);

            var userDetails = mapper.Map<User>(signUpDto);
            userDetails.CompanyId = companyDetails.CompanyId;
            userDetails.CreateDate = currentDate;
            userDetails.ProfileId = profileDetails.ProfileId;
            userDetails.CreateLoginId = 0;
            //userDetails.Password = passwordHelper.HashPassword(signUpDto.Password);
            repository.Add(userDetails);


            //return repository.Get<Country>().AsQueryable().AsNoTracking().ToList();
        }

        public object Login(LoginDto loginDto)
        {
            var user = repository.Get<User>(x => x.Login == loginDto.MobileNo && x.Password == loginDto.Password && x.IsActive && !x.IsDeleted)
                //.Include(x => x.Profile)
                .FirstOrDefault();

            var user1 = repository.Get<User>(x => x.Login == loginDto.MobileNo && x.Password == loginDto.Password && x.IsActive && !x.IsDeleted)
                .Include(x => x.Profile)
                .FirstOrDefault();

            var user2 = repository.Get<User>().AsQueryable()
                .Include(x => x.Company)
                .FirstOrDefault();

            if (user != null)
            {
                var token = GenerateJwtToken(user);
                return new { user };
            }


            throw new ArgumentException("Invalid username or password");
        }
        #endregion

        #region Private Methods
        private static bool CheckDuplicate(SignUpDto signUpDto)
        {
            return false;
        }

        private string GenerateJwtToken(User user)
        {
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.FirstName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            authClaims.Add(new Claim(ClaimTypes.Email, user.EmailId));
            authClaims.Add(new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()));

            //var 

            throw new NotImplementedException();
        }
        #endregion
    }
}
