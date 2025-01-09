using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Employee
{
    public int CompanyId { get; set; }

    public int EmployeeId { get; set; }

    public int TitleId { get; set; }

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MotherName { get; set; }

    public string? SpouseName { get; set; }

    public string Initials { get; set; } = null!;

    public string Gender { get; set; } = null!;

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

    public string CurrentAddress { get; set; } = null!;

    public int CurrentCityId { get; set; }

    public int CurrentStateId { get; set; }

    public int CurrentCountryId { get; set; }

    public string CurrentPincode { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string? MobileNo2 { get; set; }

    public string EmailId { get; set; } = null!;

    public string EmergencyContactNo { get; set; } = null!;

    public string? PhotoImage { get; set; }

    public int? UserId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreareLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<AdvanceApplication> AdvanceApplications { get; set; } = new List<AdvanceApplication>();

    public virtual ICollection<AnnouncementDetail> AnnouncementDetails { get; set; } = new List<AnnouncementDetail>();

    public virtual ICollection<AssetAllotment> AssetAllotments { get; set; } = new List<AssetAllotment>();

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual BloodGroup? BloodGroup { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<EmployeeBank> EmployeeBanks { get; set; } = new List<EmployeeBank>();

    public virtual ICollection<EmployeeDocument> EmployeeDocuments { get; set; } = new List<EmployeeDocument>();

    public virtual ICollection<EmployeeExperience> EmployeeExperiences { get; set; } = new List<EmployeeExperience>();

    public virtual ICollection<EmployeeProfile> EmployeeProfiles { get; set; } = new List<EmployeeProfile>();

    public virtual ICollection<EmployeeQualification> EmployeeQualifications { get; set; } = new List<EmployeeQualification>();

    public virtual ICollection<ExpenseClaim> ExpenseClaims { get; set; } = new List<ExpenseClaim>();

    public virtual ICollection<LeaveApplication> LeaveApplications { get; set; } = new List<LeaveApplication>();

    public virtual ICollection<LoanApplication> LoanApplications { get; set; } = new List<LoanApplication>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<OvertimeApplication> OvertimeApplications { get; set; } = new List<OvertimeApplication>();

    public virtual ICollection<Payroll> Payrolls { get; set; } = new List<Payroll>();

    public virtual City? PermanentCity { get; set; }

    public virtual Country? PermanentCountry { get; set; }

    public virtual State? PermanentState { get; set; }

    public virtual ICollection<ResignationApplication> ResignationApplications { get; set; } = new List<ResignationApplication>();

    public virtual ICollection<RosterDetail> RosterDetails { get; set; } = new List<RosterDetail>();

    public virtual ICollection<Tickit> Tickits { get; set; } = new List<Tickit>();

    public virtual Title Title { get; set; } = null!;

    public virtual User? User { get; set; }
}
