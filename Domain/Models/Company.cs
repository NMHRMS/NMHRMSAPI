using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public string Name { get; set; } = null!;

    public string? ShortName { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public int CountryId { get; set; }

    public string? Pincode { get; set; }

    public string EmailId { get; set; } = null!;

    public string? Url { get; set; }

    public string? Logo { get; set; }

    public string? LetterHeadImage { get; set; }

    public string? Gstno { get; set; }

    public string? FinancialYearFlag { get; set; }

    public bool IsActive { get; set; }

    public string? Vision { get; set; }

    public string? Mission { get; set; }

    public string? Profile { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<AdvanceApplication> AdvanceApplications { get; set; } = new List<AdvanceApplication>();

    public virtual ICollection<AnnouncementDetail> AnnouncementDetails { get; set; } = new List<AnnouncementDetail>();

    public virtual ICollection<Announcement> Announcements { get; set; } = new List<Announcement>();

    public virtual ICollection<AssetAllotment> AssetAllotments { get; set; } = new List<AssetAllotment>();

    public virtual ICollection<AssetType> AssetTypes { get; set; } = new List<AssetType>();

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual ICollection<AssociateTaxis> AssociateTaxes { get; set; } = new List<AssociateTaxis>();

    public virtual ICollection<AttendanceDaily> AttendanceDailies { get; set; } = new List<AttendanceDaily>();

    public virtual ICollection<AttendanceMode> AttendanceModes { get; set; } = new List<AttendanceMode>();

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual ICollection<CompanyProgram> CompanyPrograms { get; set; } = new List<CompanyProgram>();

    public virtual ICollection<ContractType> ContractTypes { get; set; } = new List<ContractType>();

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<DeductionType> DeductionTypes { get; set; } = new List<DeductionType>();

    public virtual ICollection<Deduction> Deductions { get; set; } = new List<Deduction>();

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Designation> Designations { get; set; } = new List<Designation>();

    public virtual ICollection<DocumentType> DocumentTypes { get; set; } = new List<DocumentType>();

    public virtual ICollection<EarningType> EarningTypes { get; set; } = new List<EarningType>();

    public virtual ICollection<Earning> Earnings { get; set; } = new List<Earning>();

    public virtual ICollection<EmployeeBank> EmployeeBanks { get; set; } = new List<EmployeeBank>();

    public virtual ICollection<EmployeeCategory> EmployeeCategories { get; set; } = new List<EmployeeCategory>();

    public virtual ICollection<EmployeeDocument> EmployeeDocuments { get; set; } = new List<EmployeeDocument>();

    public virtual ICollection<EmployeeExperience> EmployeeExperiences { get; set; } = new List<EmployeeExperience>();

    public virtual ICollection<EmployeeProfile> EmployeeProfiles { get; set; } = new List<EmployeeProfile>();

    public virtual ICollection<EmployeeQualification> EmployeeQualifications { get; set; } = new List<EmployeeQualification>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<ExitType> ExitTypes { get; set; } = new List<ExitType>();

    public virtual ICollection<ExpenseClaim> ExpenseClaims { get; set; } = new List<ExpenseClaim>();

    public virtual ICollection<ExpenseType> ExpenseTypes { get; set; } = new List<ExpenseType>();

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual ICollection<HolidayTemplateDay> HolidayTemplateDays { get; set; } = new List<HolidayTemplateDay>();

    public virtual ICollection<HolidayTemplate> HolidayTemplates { get; set; } = new List<HolidayTemplate>();

    public virtual ICollection<LeaveApplicationDetail> LeaveApplicationDetails { get; set; } = new List<LeaveApplicationDetail>();

    public virtual ICollection<LeaveApplication> LeaveApplications { get; set; } = new List<LeaveApplication>();

    public virtual ICollection<LeaveBalance> LeaveBalances { get; set; } = new List<LeaveBalance>();

    public virtual ICollection<LeaveType> LeaveTypes { get; set; } = new List<LeaveType>();

    public virtual ICollection<LoanApplication> LoanApplications { get; set; } = new List<LoanApplication>();

    public virtual ICollection<LoanDetail> LoanDetails { get; set; } = new List<LoanDetail>();

    public virtual ICollection<LoanType> LoanTypes { get; set; } = new List<LoanType>();

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<Month> Months { get; set; } = new List<Month>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<OvertimeApplication> OvertimeApplications { get; set; } = new List<OvertimeApplication>();

    public virtual ICollection<OvertimePolicy> OvertimePolicies { get; set; } = new List<OvertimePolicy>();

    public virtual ICollection<PayrollDeduction> PayrollDeductions { get; set; } = new List<PayrollDeduction>();

    public virtual ICollection<PayrollEarning> PayrollEarnings { get; set; } = new List<PayrollEarning>();

    public virtual ICollection<PayrollReimbursement> PayrollReimbursements { get; set; } = new List<PayrollReimbursement>();

    public virtual ICollection<Payroll> Payrolls { get; set; } = new List<Payroll>();

    public virtual ICollection<ProfilePrivilege> ProfilePrivileges { get; set; } = new List<ProfilePrivilege>();

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual ICollection<Qualification> Qualifications { get; set; } = new List<Qualification>();

    public virtual ICollection<ReimbursementType> ReimbursementTypes { get; set; } = new List<ReimbursementType>();

    public virtual ICollection<Reimbursement> Reimbursements { get; set; } = new List<Reimbursement>();

    public virtual ICollection<ResignationApplication> ResignationApplications { get; set; } = new List<ResignationApplication>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<RosterDetail> RosterDetails { get; set; } = new List<RosterDetail>();

    public virtual ICollection<Roster> Rosters { get; set; } = new List<Roster>();

    public virtual ICollection<SalaryEarning> SalaryEarnings { get; set; } = new List<SalaryEarning>();

    public virtual ICollection<SalaryReimbursement> SalaryReimbursements { get; set; } = new List<SalaryReimbursement>();

    public virtual ICollection<SalaryTemplate> SalaryTemplates { get; set; } = new List<SalaryTemplate>();

    public virtual ICollection<ShiftDetail> ShiftDetails { get; set; } = new List<ShiftDetail>();

    public virtual ICollection<Shift> Shifts { get; set; } = new List<Shift>();

    public virtual ICollection<Statutory> Statutories { get; set; } = new List<Statutory>();

    public virtual ICollection<StatutorySlab> StatutorySlabs { get; set; } = new List<StatutorySlab>();

    public virtual ICollection<SystemModule> SystemModules { get; set; } = new List<SystemModule>();

    public virtual ICollection<TaskAttachment> TaskAttachments { get; set; } = new List<TaskAttachment>();

    public virtual ICollection<TaskHistory> TaskHistories { get; set; } = new List<TaskHistory>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

    public virtual ICollection<TeamMember> TeamMembers { get; set; } = new List<TeamMember>();

    public virtual ICollection<Team> Teams { get; set; } = new List<Team>();

    public virtual ICollection<TickitAttachment> TickitAttachments { get; set; } = new List<TickitAttachment>();

    public virtual ICollection<TickitType> TickitTypes { get; set; } = new List<TickitType>();

    public virtual ICollection<Tickit> Tickits { get; set; } = new List<Tickit>();

    public virtual ICollection<Title> Titles { get; set; } = new List<Title>();

    public virtual ICollection<Udfdatum> Udfdata { get; set; } = new List<Udfdatum>();

    public virtual ICollection<Udf> Udfs { get; set; } = new List<Udf>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<WeeklyOffTemplateDay> WeeklyOffTemplateDays { get; set; } = new List<WeeklyOffTemplateDay>();

    public virtual ICollection<WeeklyOffTemplate> WeeklyOffTemplates { get; set; } = new List<WeeklyOffTemplate>();

    public virtual ICollection<Year> Years { get; set; } = new List<Year>();
}
