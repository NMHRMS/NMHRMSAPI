using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Master
{
    public class BloodGroupDto
    {
        public int BloodGroupId { get; set; }

        public string BloodGroup1 { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }
    }
}
