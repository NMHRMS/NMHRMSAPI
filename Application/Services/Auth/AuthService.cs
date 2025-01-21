using Application.Dtos.Auth;
using Application.Interfaces.Auth;
using AutoMapper;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
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
        private readonly IConfiguration configuration;

        public AuthService(IRepository repository, IMapper mapper, IPasswordHelper passwordHelper, IConfiguration configuration)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.passwordHelper = passwordHelper;
            this.configuration = configuration;
        }

        #region Puublic Methods
        public void SignUp(SignUpDto signUpDto)
        {
            if (IsDuplicateEmail(signUpDto.EmailID))
                throw new ArgumentException("Email Id Already Exists");

            var currentDate = DateTime.Now;
            var companyDetails = mapper.Map<Company>(signUpDto);
            companyDetails.CreateDate = currentDate;
            companyDetails.IsActive = true;
            repository.Add(companyDetails);

            var roleDetails = new Domain.Models.Role();
            roleDetails.Role1 = ProfileTypes.Admin.ToString();
            roleDetails.CreateDate = currentDate;
            roleDetails.CompanyId = companyDetails.CompanyId;
            roleDetails.CreareLoginId = 0;
            roleDetails.IsActive = true;
            repository.Add(roleDetails);

            var userDetails = mapper.Map<User>(signUpDto);
            userDetails.CompanyId = companyDetails.CompanyId;
            userDetails.CreateDate = currentDate;
            userDetails.RoleId = roleDetails.RoleId;
            userDetails.IsActive = true;
            userDetails.CreateLoginId = 0;
            //userDetails.Password = passwordHelper.HashPassword(signUpDto.Password);
            repository.Add(userDetails);


            //return repository.Get<Country>().AsQueryable().AsNoTracking().ToList();
        }

        public List<LoginCompanyDto> GetLoginCompanies(LoginDto loginDto)
        {
            if(IsValidUser(loginDto))
            {
                var result = repository.Get<Company>(x => x.MobileNo == loginDto.MobileNo && x.IsActive && !x.IsDeleted).ToList();
                var companyDetails = mapper.Map<List<LoginCompanyDto>>(result);
                return companyDetails;
            }

            throw new ArgumentException("Invalid username or password");
        }

        public object Login(LoginDto loginDto)
        {
            var user = repository.Get<User>(x => x.Login == loginDto.MobileNo && x.Password == loginDto.Password && x.CompanyId == loginDto.CompanyId && x.IsActive && !x.IsDeleted)
                .Include(x => x.Role).FirstOrDefault();

            if (user != null)
            {
                var jwtToken = GenerateJwtToken(user);
                var userDetails = mapper.Map<UserDto>(user);
                var RoleDetails = mapper.Map<RoleDto>(user.Role);
                return new { UserDetails = userDetails, RoleDetails = RoleDetails, Token = jwtToken };
            }

            throw new ArgumentException("Invalid username or password");
        }
        #endregion

        #region Private Methods

        private bool IsValidUser(LoginDto loginDto)
        {
            return repository.Any<User>(x => x.Login == loginDto.MobileNo && x.Password == loginDto.Password && x.IsActive && !x.IsDeleted);
        }

        private bool IsDuplicateEmail(string emailId)
        {
            return repository.Any<User>(x => x.EmailId == emailId);
        }

        private string GenerateJwtToken(User user)
        {
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.FirstName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Email, user.EmailId),
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Role, user.Role.Role1)
            };

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["AppSettings:JwtSecret"]));
            var token = new JwtSecurityToken(
                expires: DateTime.UtcNow.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256));
            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return jwtToken;
        }
        #endregion
    }
}
