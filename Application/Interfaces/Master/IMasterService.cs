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
        List<CountriesDto> GetCountries();
    }
}
