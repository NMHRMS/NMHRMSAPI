using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Master
{
    public class StatesDto
    {
        public int StateId { get; set; }

        public string Name { get; set; } = null!;

        public string ShortName { get; set; } = null!;

        public int? CountryId { get; set; }
        public List<CitiesDto> Cities { get; set; }
    }
}
