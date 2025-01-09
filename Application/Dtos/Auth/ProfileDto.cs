using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Auth
{
    public class ProfileDto
    {
        public int ProfileId { get; set; }

        public string Profile1 { get; set; } = null!;

        public bool IsAdmin { get; set; }
    }
}
