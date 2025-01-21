using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Master
{
    public class CountriesDto
    {
        public int CountryId { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public string Currency { get; set; }

        public string? CurrencySymbol { get; set; }

        public List<StatesDto> States { get; set; }
    }
}
