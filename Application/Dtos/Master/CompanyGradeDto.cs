using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Master
{
    public class CompanyGradeDto
    {
        public required int CompanyID { get; set; }
        public int GradeID { get; set; }
        public required string Grade { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "SequenceNo must be greater than 0.")]
        public required int SequenceNo { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
