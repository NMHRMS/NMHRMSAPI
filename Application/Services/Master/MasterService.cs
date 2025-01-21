using Application.Dtos.Auth;
using Application.Dtos.Master;
using Application.Interfaces.Employee;
using Application.Interfaces.Master;
using AutoMapper;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Master
{
    public class MasterService : IMasterService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly IHttpContextAccessor httpContextAccessor;

        public MasterService(IRepository repository, IMapper mapper, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.configuration = configuration;
            this.httpContextAccessor = httpContextAccessor;
        }

        #region Public Methods
        public void AddUpdateGrades(CompanyGradeDto companyGradeDto)
        {
            var userId = httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            var currentDate = DateTime.Now;
            if (companyGradeDto.GradeID > 0)
            {
                var gradeDetails = repository.FirstOrDefault<Grade>(x => x.GradeId == companyGradeDto.GradeID);
                mapper.Map(companyGradeDto, gradeDetails);
                gradeDetails.UpdateDate = currentDate;
                gradeDetails.UpdateLoginId = Convert.ToInt32(userId);
                repository.Update(gradeDetails);
            }
            else
            {
                Grade gradeDetails = new();
                mapper.Map(companyGradeDto, gradeDetails);
                gradeDetails.CreateDate = currentDate;
                gradeDetails.CreateLoginId = Convert.ToInt32(userId);
                repository.Add(gradeDetails);
            }
        }

        /// <summary>
        /// Method returns countries, states and cities
        /// </summary>
        /// <returns></returns>
        public List<CountriesDto> GetCountries()
        {
            var countries = repository.Get<Country>(x => !x.IsDeleted && x.IsActive).Include(x => x.States).ThenInclude(x => x.Cities).ToList();
            var result = mapper.Map<List<Country>, List<CountriesDto>>(countries);
            return result;
        }
        #endregion

        #region Private Methods
        #endregion
    }
}
