using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Master
{
    public class QualificationDto
    {
        public int QualificationId { get; set; }

        public string Qualification1 { get; set; } = null!;

        public string? ShortName { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }
    }
}
