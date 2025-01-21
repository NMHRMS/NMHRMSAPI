using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Auth
{
    public class LoginDto
    {
        public required string MobileNo { get; set; }
        public required string Password { get; set; }
        public required int CompanyId { get; set; }
    }
}
