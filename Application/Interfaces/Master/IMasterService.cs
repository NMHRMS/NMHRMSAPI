using Application.Dtos.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Master
{
    public interface IMasterService
    {
        void AddUpdateGrades(CompanyGradeDto companyGradeDto);
        List<CompanyGradeDto> GetCompanyGrades();
        void DeleteGrade(int gradeId);
        List<CountriesDto> GetCountries();
        List<LocationDto> GetBranches();
        void AddUpdateBranch(LocationDto locationDto);
        void DeleteBranch(int locationId);
        List<TitleDto> GetTitles();
        void AddUpdateTitle(TitleDto titleDto);
        void DeleteTitle(int titleId);
        List<BloodGroupDto> GetBloodGroups();
        void AddUpdateBloodGroup(BloodGroupDto bloodGroupDto);
        void DeleteBloodGroup(int bloodGroupId);
        List<QualificationDto> GetQualification();
        void AddUpdateQualification(QualificationDto qualificationDto);
        void DeleteQualification(int qualificationId);
        List<ContractTypeDto> GetContractorTypes();
        void AddUpdateContractorType(ContractTypeDto contractTypeDto);
        void DeleteContractorType(int contractTypeId);
    }
}
