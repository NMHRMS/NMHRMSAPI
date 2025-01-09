using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Auth
{
    public class UserDto
    {
        public int CompanyId { get; set; }

        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string? LastName { get; set; }
        public string EmailId { get; set; }
    }
}
