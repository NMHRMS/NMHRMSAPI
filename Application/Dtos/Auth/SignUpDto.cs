using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Auth
{
    public class SignUpDto
    {
        public required string Name { get; set; }
        public required string MobileNo { get; set; }
        public required string EmailID { get; set; }
        public required string Password { get; set; }
        [Compare("Password")]
        public required string ConfirmPassword { get; set; }
        public bool NewsLetters { get; set; }
        public required int CountryId { get; set; }
    }
}