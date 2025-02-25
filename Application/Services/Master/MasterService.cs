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

        public List<CompanyGradeDto> GetCompanyGrades()
        {
            var grades = repository.Get<Grade>(x => !x.IsDeleted && x.IsActive).ToList();
            var result = mapper.Map<List<Grade>, List<CompanyGradeDto>>(grades);
            return result;
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

        public void DeleteGrade(int gradeId)
        {
            // Check if the Location exists
            var gradeDetails = repository.FirstOrDefault<Grade>(x => x.GradeId == gradeId);
            if (gradeDetails == null)
            {
                throw new ArgumentException("Grade not found.");
            }

            gradeDetails.IsDeleted = true;
            gradeDetails.IsActive = false;
            gradeDetails.UpdateDate = DateTime.Now;
            repository.Update(gradeDetails);
        }

        /// <summary>
        /// Method returns Branch/Location
        /// </summary>
        /// <returns></returns>
        public List<LocationDto> GetBranches()
        {
            var locations = repository.Get<Location>(x => !x.IsDeleted && x.IsActive).ToList();
            var result = mapper.Map<List<Location>, List<LocationDto>>(locations);
            return result;
        }

        public void AddUpdateBranch(LocationDto locationDto)
        {
            if (IsDuplicateLocation(locationDto.Location1, locationDto.ShortName))
                throw new ArgumentException("Location or ShortName already exists.");

            var userId = httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            var userData = repository.Get<User>(x => x.UserId == Convert.ToInt32(userId)).FirstOrDefault();
            var currentDate = DateTime.Now;
            if (locationDto.LocationId > 0)
            {
                var locationDetails = repository.FirstOrDefault<Location>(x => x.LocationId == locationDto.LocationId);
                mapper.Map(locationDto, locationDetails);
                locationDetails.UpdateDate = currentDate;
                locationDetails.UpdateLoginId = Convert.ToInt32(userId);
                repository.Update(locationDetails);
            }
            else
            {
                Location locationDetails = new();
                mapper.Map(locationDto, locationDetails);
                locationDetails.CreateDate = currentDate;
                locationDetails.CreateLoginId = Convert.ToInt32(userId);
                locationDetails.CompanyId =userData.CompanyId;
                repository.Add(locationDetails);
            }
        }

        public void DeleteBranch(int locationId)
        {
            // Check if the Location exists
            var locationDetails = repository.FirstOrDefault<Location>(x => x.LocationId == locationId);
            if (locationDetails == null)
            {
                throw new ArgumentException("Location not found.");
            }

            locationDetails.IsDeleted = true;
            locationDetails.IsActive = false;
            locationDetails.UpdateDate = DateTime.Now;  
            repository.Update(locationDetails); 
        }

        /// <summary>
        /// Method returns Titles
        /// </summary>
        /// <returns></returns>

        public List<TitleDto> GetTitles()
        {
            var titles = repository.Get<Title>(x => !x.IsDeleted && x.IsActive).ToList();
            var result = mapper.Map<List<Title>, List<TitleDto>>(titles);
            return result;
        }


        public void AddUpdateTitle(TitleDto titleDto)
        {
            if (IsDuplicateTitle(titleDto.Title1, titleDto.ShortName))
                throw new ArgumentException("Title or ShortName already exists.");

            var userId = httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            var userData = repository.Get<User>(x => x.UserId == Convert.ToInt32(userId)).FirstOrDefault();
            var currentDate = DateTime.Now;
            if (titleDto.TitleId > 0)
            {
                var titleDetails = repository.FirstOrDefault<Title>(x => x.TitleId == titleDto.TitleId);
                mapper.Map(titleDto, titleDetails);
                titleDetails.UpdateDate = currentDate;
                titleDetails.UpdateLoginId = Convert.ToInt32(userId);
                repository.Update(titleDetails);
            }
            else
            {
                Title titleDetails = new();
                mapper.Map(titleDto, titleDetails);
                titleDetails.CreateDate = currentDate;
                titleDetails.CreareLoginId = Convert.ToInt32(userId);
                titleDetails.CompanyId = userData.CompanyId;
                repository.Add(titleDetails);
            }
        }

        public void DeleteTitle(int titleId)
        {
            // Check if the Title exists
            var titleDetails = repository.FirstOrDefault<Title>(x => x.TitleId == titleId);
            if (titleDetails == null)
            {
                throw new ArgumentException("Title not found.");
            }
            titleDetails.IsDeleted = true;
            titleDetails.IsActive = false;
            titleDetails.UpdateDate = DateTime.Now;
            repository.Update(titleDetails);
        }

        /// <summary>
        /// Method returns BloodGroup
        /// </summary>
        /// <returns></returns>

        public List<BloodGroupDto> GetBloodGroups()
        {
            var bloodGroups = repository.Get<BloodGroup>(x => !x.IsDeleted && x.IsActive).ToList();
            var result = mapper.Map<List<BloodGroup>, List<BloodGroupDto>>(bloodGroups);
            return result;
        }


        public void AddUpdateBloodGroup(BloodGroupDto bloodGroupDto)
        {
            if (IsDuplicateBloodGroup(bloodGroupDto.BloodGroup1))
                throw new ArgumentException("BloodGroup already exists.");
            var userId = httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            var currentDate = DateTime.Now;
            if (bloodGroupDto.BloodGroupId > 0)
            {
                var bloodGroupDetails = repository.FirstOrDefault<BloodGroup>(x => x.BloodGroupId == bloodGroupDto.BloodGroupId);
                mapper.Map(bloodGroupDto, bloodGroupDetails);
                bloodGroupDetails.UpdateDate = currentDate;
                bloodGroupDetails.UpdateLoginId = Convert.ToInt32(userId);
                repository.Update(bloodGroupDetails);
            }
            else
            {
                BloodGroup bloodGroupDetails = new();
                mapper.Map(bloodGroupDto, bloodGroupDetails);
                bloodGroupDetails.CreateDate = currentDate;
                bloodGroupDetails.CreareLoginId = Convert.ToInt32(userId);
                repository.Add(bloodGroupDetails);
            }
        }

        public void DeleteBloodGroup(int bloodGroupId)
        {
            // Check if the Title exists
            var bloodGroupDetails = repository.FirstOrDefault<BloodGroup>(x => x.BloodGroupId == bloodGroupId);
            if (bloodGroupDetails == null)
            {
                throw new ArgumentException("BloodGroup not found.");
            }
            bloodGroupDetails.IsDeleted = true;
            bloodGroupDetails.IsActive = false;
            bloodGroupDetails.UpdateDate = DateTime.Now;
            repository.Update(bloodGroupDetails);
        }

        /// <summary>
        /// Method returns Qualification
        /// </summary>
        /// <returns></returns>

        public List<QualificationDto> GetQualification()
        {
            var qualifications = repository.Get<Qualification>(x => !x.IsDeleted && x.IsActive).ToList();
            var result = mapper.Map<List<Qualification>, List<QualificationDto>>(qualifications);
            return result;
        }


        public void AddUpdateQualification(QualificationDto qualificationDto)
        {
            if (IsDuplicateQualification(qualificationDto.Qualification1,qualificationDto.ShortName))
                throw new ArgumentException("Qualification or ShortName already exists.");
            var userId = httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            var userData = repository.Get<User>(x => x.UserId == Convert.ToInt32(userId)).FirstOrDefault();
            var currentDate = DateTime.Now;
            if (qualificationDto.QualificationId > 0)
            {
                var qualificationDetails = repository.FirstOrDefault<Qualification>(x => x.QualificationId == qualificationDto.QualificationId);
                mapper.Map(qualificationDto, qualificationDetails);
                qualificationDetails.UpdateDate = currentDate;
                qualificationDetails.UpdateLoginId = Convert.ToInt32(userId);
                repository.Update(qualificationDetails);
            }
            else
            {
                Qualification qualificationDetails = new();
                mapper.Map(qualificationDto, qualificationDetails);
                qualificationDetails.CreateDate = currentDate;
                qualificationDetails.CreateLoginId = Convert.ToInt32(userId);
                qualificationDetails.CompanyId = userData.CompanyId;
                repository.Add(qualificationDetails);
            }
        }

        public void DeleteQualification(int qualificationId)
        {
            // Check if the Title exists
            var qualificationDetails = repository.FirstOrDefault<Qualification>(x => x.QualificationId == qualificationId);
            if (qualificationDetails == null)
            {
                throw new ArgumentException("Qualification not found.");
            }
            qualificationDetails.IsDeleted = true;
            qualificationDetails.IsActive = false;
            qualificationDetails.UpdateDate = DateTime.Now;
            repository.Update(qualificationDetails);
        }

        /// <summary>
        /// Method returns ContractorTypes
        /// </summary>
        /// <returns></returns>

        public List<ContractTypeDto> GetContractorTypes()
        {
            var qualifications = repository.Get<ContractType>(x => !x.IsDeleted && x.IsActive).ToList();
            var result = mapper.Map<List<ContractType>, List<ContractTypeDto>>(qualifications);
            return result;
        }


        public void AddUpdateContractorType(ContractTypeDto contractTypeDto)
        {
            if (IsDuplicateContractorType(contractTypeDto.ContractType1))
                throw new ArgumentException("ContractType already exists.");
            var userId = httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            var userData = repository.Get<User>(x => x.UserId == Convert.ToInt32(userId)).FirstOrDefault();
            var currentDate = DateTime.Now;
            if (contractTypeDto.ContractTypeId > 0)
            {
                var contractorTypeDetails = repository.FirstOrDefault<ContractType>(x => x.ContractTypeId == contractTypeDto.ContractTypeId);
                mapper.Map(contractTypeDto, contractorTypeDetails);
                contractorTypeDetails.UpdateDate = currentDate;
                contractorTypeDetails.UpdateLoginId = Convert.ToInt32(userId);
                repository.Update(contractorTypeDetails);
            }
            else
            {
                ContractType contractorTypeDetails = new();
                mapper.Map(contractTypeDto, contractorTypeDetails);
                contractorTypeDetails.CreateDate = currentDate;
                contractorTypeDetails.CreateLoginId = Convert.ToInt32(userId);
                contractorTypeDetails.CompanyId = userData.CompanyId;
                repository.Add(contractorTypeDetails);
            }
        }

        public void DeleteContractorType(int contractTypeId)
        {
            // Check if the Title exists
            var contractorDetails = repository.FirstOrDefault<ContractType>(x => x.ContractTypeId == contractTypeId);
            if (contractorDetails == null)
            {
                throw new ArgumentException("ContractorType not found.");
            }
            contractorDetails.IsDeleted = true;
            contractorDetails.IsActive = false;
            contractorDetails.UpdateDate = DateTime.Now;
            repository.Update(contractorDetails);
        }
        #endregion

        #region Private Methods

        private bool IsDuplicateLocation(string Location, string ShortName)
        {
            return repository.Any<Location>(x => x.Location1 == Location || x.ShortName==ShortName);
        }

        private bool IsDuplicateTitle(string Title, string ShortName)
        {
            return repository.Any<Title>(x => x.Title1 == Title || x.ShortName == ShortName);
        }

        private bool IsDuplicateBloodGroup(string BloodGroup)
        {
            return repository.Any<BloodGroup>(x => x.BloodGroup1 == BloodGroup);
        }

        private bool IsDuplicateQualification(string Qualification,string ShortName)
        {
            return repository.Any<Qualification>(x => x.Qualification1 == Qualification || x.ShortName==ShortName);
        }

        private bool IsDuplicateContractorType(string ContractorType)
        {
            return repository.Any<ContractType>(x => x.ContractType1 == ContractorType);
        }
        #endregion
    }
}
