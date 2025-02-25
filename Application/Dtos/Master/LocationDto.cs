using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Master
{
    public class LocationDto
    {
        public int LocationId { get; set; }
        public string Location1 { get; set; } = null!;

        public string ShortName { get; set; } = null!;

        public string Address1 { get; set; } = null!;

        public string? Address2 { get; set; }

        public string? Address3 { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public int CountryId { get; set; }

        public string? Pincode { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
