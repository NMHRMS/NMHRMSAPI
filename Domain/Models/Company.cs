using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string AddressLine1 { get; set; } = null!;

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public int CountryId { get; set; }

    public string Pincode { get; set; } = null!;

    public string EmailId { get; set; } = null!;

    public string? Url { get; set; }

    public string? Logo { get; set; }

    public string? LetterHeadImage { get; set; }

    public string? Gstno { get; set; }

    public string FinancialYearFlag { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? Vision { get; set; }

    public string? Mission { get; set; }

    public string? Profile { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<AttendanceDaily> AttendanceDailies { get; set; } = new List<AttendanceDaily>();

    public virtual ICollection<AttendanceMode> AttendanceModes { get; set; } = new List<AttendanceMode>();

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual ICollection<CompanyProgram> CompanyPrograms { get; set; } = new List<CompanyProgram>();

    public virtual ICollection<ContractType> ContractTypes { get; set; } = new List<ContractType>();

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Designation> Designations { get; set; } = new List<Designation>();

    public virtual ICollection<DocumentType> DocumentTypes { get; set; } = new List<DocumentType>();

    public virtual ICollection<EmployeeBank> EmployeeBanks { get; set; } = new List<EmployeeBank>();

    public virtual ICollection<EmployeeCategory> EmployeeCategories { get; set; } = new List<EmployeeCategory>();

    public virtual ICollection<EmployeeDocument> EmployeeDocuments { get; set; } = new List<EmployeeDocument>();

    public virtual ICollection<EmployeeExperience> EmployeeExperiences { get; set; } = new List<EmployeeExperience>();

    public virtual ICollection<EmployeeProfile> EmployeeProfiles { get; set; } = new List<EmployeeProfile>();

    public virtual ICollection<EmployeeQualification> EmployeeQualifications { get; set; } = new List<EmployeeQualification>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual ICollection<HolidayTemplateDay> HolidayTemplateDays { get; set; } = new List<HolidayTemplateDay>();

    public virtual ICollection<HolidayTemplate> HolidayTemplates { get; set; } = new List<HolidayTemplate>();

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<Month> Months { get; set; } = new List<Month>();

    public virtual ICollection<ProfilePrivilege> ProfilePrivileges { get; set; } = new List<ProfilePrivilege>();

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual ICollection<Qualification> Qualifications { get; set; } = new List<Qualification>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<RosterDetail> RosterDetails { get; set; } = new List<RosterDetail>();

    public virtual ICollection<Roster> Rosters { get; set; } = new List<Roster>();

    public virtual ICollection<ShiftDetail> ShiftDetails { get; set; } = new List<ShiftDetail>();

    public virtual ICollection<Shift> Shifts { get; set; } = new List<Shift>();

    public virtual ICollection<State> States { get; set; } = new List<State>();

    public virtual ICollection<SystemModule> SystemModules { get; set; } = new List<SystemModule>();

    public virtual ICollection<Title> Titles { get; set; } = new List<Title>();

    public virtual ICollection<Udfdatum> Udfdata { get; set; } = new List<Udfdatum>();

    public virtual ICollection<Udf> Udfs { get; set; } = new List<Udf>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<WeeklyOffTemplateDay> WeeklyOffTemplateDays { get; set; } = new List<WeeklyOffTemplateDay>();

    public virtual ICollection<WeeklyOffTemplate> WeeklyOffTemplates { get; set; } = new List<WeeklyOffTemplate>();

    public virtual ICollection<Year> Years { get; set; } = new List<Year>();
}
