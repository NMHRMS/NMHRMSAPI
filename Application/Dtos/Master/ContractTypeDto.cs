using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Master
{
    public class ContractTypeDto
    {
        public int ContractTypeId { get; set; }

        public string ContractType1 { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }
    }
}
