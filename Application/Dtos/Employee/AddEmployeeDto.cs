using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Employee
{
    public class AddEmployeeDto
    {
        public int TitleId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string? MotherName { get; set; }

        public string? SpouseName { get; set; }

        public string Initials { get; set; }

        public string Gender { get; set; }

        public DateOnly Dob { get; set; }

        public bool MaritalStatus { get; set; }

        public int? BloodGroupId { get; set; }

        public bool PhysicallyChallenged { get; set; }

        public string? Pan { get; set; }

        public string? Aadhaar { get; set; }

        public string? PermanentAddress { get; set; }

        public int? PermanentCityId { get; set; }

        public int? PermanentStateId { get; set; }

        public int? PermanentCountryId { get; set; }

        public string? PermanentPincode { get; set; }

        public string CurrentAddress { get; set; }

        public int CurrentCityId { get; set; }

        public int CurrentStateId { get; set; }

        public int CurrentCountryId { get; set; }

        public string CurrentPincode { get; set; }

        public string MobileNo { get; set; }

        public string? MobileNo2 { get; set; }

        public string EmailId { get; set; }

        public string EmergencyContactNo { get; set; }

        public string? PhotoImage { get; set; }

        public int? UserId { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

    }
}
