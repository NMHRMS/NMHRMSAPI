using Application.Dtos.Auth;
using Application.Interfaces.Auth;
using AutoMapper;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            companyDetails.CountryId = 4;
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
        #endregion

        #region Private Methods
        private static bool CheckDuplicate(SignUpDto signUpDto)
        {
            return false;
        }
        #endregion
    }
}
