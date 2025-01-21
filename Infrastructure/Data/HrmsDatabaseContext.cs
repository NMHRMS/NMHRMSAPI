using System;
using System.Collections.Generic;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public partial class HrmsDatabaseContext : DbContext
{
    public HrmsDatabaseContext()
    {
    }

    public HrmsDatabaseContext(DbContextOptions<HrmsDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdvanceApplication> AdvanceApplications { get; set; }

    public virtual DbSet<Announcement> Announcements { get; set; }

    public virtual DbSet<AnnouncementDetail> AnnouncementDetails { get; set; }

    public virtual DbSet<Asset> Assets { get; set; }

    public virtual DbSet<AssetAllotment> AssetAllotments { get; set; }

    public virtual DbSet<AssetType> AssetTypes { get; set; }

    public virtual DbSet<AssociateTaxis> AssociateTaxes { get; set; }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<AttendanceDaily> AttendanceDailies { get; set; }

    public virtual DbSet<AttendanceMode> AttendanceModes { get; set; }

    public virtual DbSet<BloodGroup> BloodGroups { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyModule> CompanyModules { get; set; }

    public virtual DbSet<CompanyProgram> CompanyPrograms { get; set; }

    public virtual DbSet<CompanySector> CompanySectors { get; set; }

    public virtual DbSet<CompanyType> CompanyTypes { get; set; }

    public virtual DbSet<ContractType> ContractTypes { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Deduction> Deductions { get; set; }

    public virtual DbSet<DeductionType> DeductionTypes { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Designation> Designations { get; set; }

    public virtual DbSet<DocumentType> DocumentTypes { get; set; }

    public virtual DbSet<Earning> Earnings { get; set; }

    public virtual DbSet<EarningType> EarningTypes { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeBank> EmployeeBanks { get; set; }

    public virtual DbSet<EmployeeCategory> EmployeeCategories { get; set; }

    public virtual DbSet<EmployeeDocument> EmployeeDocuments { get; set; }

    public virtual DbSet<EmployeeExperience> EmployeeExperiences { get; set; }

    public virtual DbSet<EmployeeProfile> EmployeeProfiles { get; set; }

    public virtual DbSet<EmployeeQualification> EmployeeQualifications { get; set; }

    public virtual DbSet<ExitType> ExitTypes { get; set; }

    public virtual DbSet<ExpenseClaim> ExpenseClaims { get; set; }

    public virtual DbSet<ExpenseType> ExpenseTypes { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<HolidayTemplate> HolidayTemplates { get; set; }

    public virtual DbSet<HolidayTemplateDay> HolidayTemplateDays { get; set; }

    public virtual DbSet<LeaveApplication> LeaveApplications { get; set; }

    public virtual DbSet<LeaveApplicationDetail> LeaveApplicationDetails { get; set; }

    public virtual DbSet<LeaveBalance> LeaveBalances { get; set; }

    public virtual DbSet<LeaveType> LeaveTypes { get; set; }

    public virtual DbSet<LoanApplication> LoanApplications { get; set; }

    public virtual DbSet<LoanDetail> LoanDetails { get; set; }

    public virtual DbSet<LoanType> LoanTypes { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Month> Months { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<OvertimeApplication> OvertimeApplications { get; set; }

    public virtual DbSet<OvertimePolicy> OvertimePolicies { get; set; }

    public virtual DbSet<Payroll> Payrolls { get; set; }

    public virtual DbSet<PayrollDeduction> PayrollDeductions { get; set; }

    public virtual DbSet<PayrollEarning> PayrollEarnings { get; set; }

    public virtual DbSet<PayrollReimbursement> PayrollReimbursements { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<ProfilePrivilege> ProfilePrivileges { get; set; }

    public virtual DbSet<Qualification> Qualifications { get; set; }

    public virtual DbSet<Reimbursement> Reimbursements { get; set; }

    public virtual DbSet<ReimbursementType> ReimbursementTypes { get; set; }

    public virtual DbSet<ResignationApplication> ResignationApplications { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Roster> Rosters { get; set; }

    public virtual DbSet<RosterDetail> RosterDetails { get; set; }

    public virtual DbSet<SalaryDeduction> SalaryDeductions { get; set; }

    public virtual DbSet<SalaryEarning> SalaryEarnings { get; set; }

    public virtual DbSet<SalaryReimbursement> SalaryReimbursements { get; set; }

    public virtual DbSet<SalaryTemplate> SalaryTemplates { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<ShiftDetail> ShiftDetails { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Statutory> Statutories { get; set; }

    public virtual DbSet<StatutorySlab> StatutorySlabs { get; set; }

    public virtual DbSet<SystemModule> SystemModules { get; set; }

    public virtual DbSet<SystemProgram> SystemPrograms { get; set; }

    public virtual DbSet<Domain.Models.Task> Tasks { get; set; }

    public virtual DbSet<TaskAttachment> TaskAttachments { get; set; }

    public virtual DbSet<TaskHistory> TaskHistories { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<TeamMember> TeamMembers { get; set; }

    public virtual DbSet<Tickit> Tickits { get; set; }

    public virtual DbSet<TickitAttachment> TickitAttachments { get; set; }

    public virtual DbSet<TickitType> TickitTypes { get; set; }

    public virtual DbSet<Title> Titles { get; set; }

    public virtual DbSet<Udf> Udfs { get; set; }

    public virtual DbSet<Udfdatum> Udfdata { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<WeeklyOffTemplate> WeeklyOffTemplates { get; set; }

    public virtual DbSet<WeeklyOffTemplateDay> WeeklyOffTemplateDays { get; set; }

    public virtual DbSet<Year> Years { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=Sql");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdvanceApplication>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("PK__AdvanceA__C93A4F7917B65BA3");

            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.ApplicationNo).HasMaxLength(10);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.ExpenseTypeId).HasColumnName("ExpenseTypeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.Reason).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Company).WithMany(p => p.AdvanceApplications)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdvanceApplications_Companies");

            entity.HasOne(d => d.Employee).WithMany(p => p.AdvanceApplications)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdvanceApplications_Employees");

            entity.HasOne(d => d.ExpenseType).WithMany(p => p.AdvanceApplications)
                .HasForeignKey(d => d.ExpenseTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdvanceApplications_ExpenseTypes");

            entity.HasOne(d => d.Year).WithMany(p => p.AdvanceApplications)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdvanceApplications_Years");
        });

        modelBuilder.Entity<Announcement>(entity =>
        {
            entity.HasKey(e => e.AnnouncementId).HasName("PK__Announce__9DE44554BDE6D569");

            entity.Property(e => e.AnnouncementId).HasColumnName("AnnouncementID");
            entity.Property(e => e.AnnouncmentTo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Priority)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Announcements)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Announcements_Companies");
        });

        modelBuilder.Entity<AnnouncementDetail>(entity =>
        {
            entity.HasKey(e => e.AnnouncementDetailId).HasName("PK__Announce__08BD0438F0CF658D");

            entity.Property(e => e.AnnouncementDetailId).HasColumnName("AnnouncementDetailID");
            entity.Property(e => e.AnnouncementId).HasColumnName("AnnouncementID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EngagedAt).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.AnnouncementDetails)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnnouncementDetails_Companies");

            entity.HasOne(d => d.Department).WithMany(p => p.AnnouncementDetails)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnnouncementDetails_Departments");

            entity.HasOne(d => d.Employee).WithMany(p => p.AnnouncementDetails)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnnouncementDetails_Employees");

            entity.HasOne(d => d.Location).WithMany(p => p.AnnouncementDetails)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnnouncementDetails_Locations");

            entity.HasOne(d => d.Role).WithMany(p => p.AnnouncementDetails)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnnouncementDetails_Roles");
        });

        modelBuilder.Entity<Asset>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK__Assets__43492372E3BCD018");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.SerialNo).HasMaxLength(10);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.AssetType).WithMany(p => p.Assets)
                .HasForeignKey(d => d.AssetTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assets_AssetTypes");

            entity.HasOne(d => d.Company).WithMany(p => p.Assets)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assets_Companies");

            entity.HasOne(d => d.Location).WithMany(p => p.Assets)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assets_Locations");
        });

        modelBuilder.Entity<AssetAllotment>(entity =>
        {
            entity.HasKey(e => e.AllotmentId).HasName("PK__AssetAll__E9FEF62FF5CBA9E0");

            entity.Property(e => e.AllotmentId).HasColumnName("AllotmentID");
            entity.Property(e => e.AllotedById).HasColumnName("AllotedByID");
            entity.Property(e => e.AllotmentDate).HasColumnType("datetime");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Asset).WithMany(p => p.AssetAllotments)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetAllotments_Assets");

            entity.HasOne(d => d.Company).WithMany(p => p.AssetAllotments)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetAllotments_Companies");

            entity.HasOne(d => d.Employee).WithMany(p => p.AssetAllotments)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetAllotments_Employees");

            entity.HasOne(d => d.Month).WithMany(p => p.AssetAllotments)
                .HasForeignKey(d => d.MonthId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetAllotments_Months");

            entity.HasOne(d => d.Year).WithMany(p => p.AssetAllotments)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetAllotments_Years");
        });

        modelBuilder.Entity<AssetType>(entity =>
        {
            entity.HasKey(e => e.AssetTypeId).HasName("PK__AssetTyp__FD33C2226D010D22");

            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.AssetType1)
                .HasMaxLength(50)
                .HasColumnName("AssetType");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.AssetTypes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetTypes_Companies");
        });

        modelBuilder.Entity<AssociateTaxis>(entity =>
        {
            entity.HasKey(e => e.AssociateTaxId).HasName("PK__Associat__D0D4B757C191A68A");

            entity.Property(e => e.AssociateTaxId).HasColumnName("AssociateTaxID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.TaxGroup).HasMaxLength(10);
            entity.Property(e => e.TaxName).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.AssociateTaxes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssociateTaxes_Companies");
        });

        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasKey(e => e.AttendanceId).HasName("PK__Attendan__8B69263C5D1EEFF8");

            entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Company).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attendances_Companies");

            entity.HasOne(d => d.Employee).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attendances_Employees");

            entity.HasOne(d => d.Month).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.MonthId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attendances_Months");

            entity.HasOne(d => d.Year).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attendances_Years");
        });

        modelBuilder.Entity<AttendanceDaily>(entity =>
        {
            entity.HasKey(e => e.AttendancdDailyId).HasName("PK__Attendan__FBB29A1A36D16674");

            entity.ToTable("AttendanceDaily");

            entity.Property(e => e.AttendancdDailyId).HasColumnName("AttendancdDailyID");
            entity.Property(e => e.AttendancdId).HasColumnName("AttendancdID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.InTime).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.OutTime).HasColumnType("datetime");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Attendancd).WithMany(p => p.AttendanceDailies)
                .HasForeignKey(d => d.AttendancdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttendanceDaily_Attendances");

            entity.HasOne(d => d.Company).WithMany(p => p.AttendanceDailies)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttendanceDaily_Companies");
        });

        modelBuilder.Entity<AttendanceMode>(entity =>
        {
            entity.HasKey(e => e.AttendanceModeId).HasName("PK__Attendan__AA90702B1657F31A");

            entity.Property(e => e.AttendanceModeId)
                .ValueGeneratedNever()
                .HasColumnName("AttendanceModeID");
            entity.Property(e => e.AttendanceMode1)
                .HasMaxLength(25)
                .HasColumnName("AttendanceMode");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.AttendanceModes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttendanceModes_Companies");
        });

        modelBuilder.Entity<BloodGroup>(entity =>
        {
            entity.HasKey(e => e.BloodGroupId).HasName("PK__BloodGro__4398C6AF80340BF7");

            entity.Property(e => e.BloodGroupId).HasColumnName("BloodGroupID");
            entity.Property(e => e.BloodGroup1)
                .HasMaxLength(25)
                .HasColumnName("BloodGroup");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__Cities__F2D21A960BE757DC");

            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.State).WithMany(p => p.Cities)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cities_States");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__Companie__2D971C4C933CC0A6");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.AddressLine1).HasMaxLength(100);
            entity.Property(e => e.AddressLine2).HasMaxLength(100);
            entity.Property(e => e.AddressLine3).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CompanyTypeId).HasColumnName("CompanyTypeID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .HasColumnName("EmailID");
            entity.Property(e => e.FinancialYearFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Gstno)
                .HasMaxLength(20)
                .HasColumnName("GSTNO");
            entity.Property(e => e.Mission).IsUnicode(false);
            entity.Property(e => e.MobileNo).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Pincode).HasMaxLength(10);
            entity.Property(e => e.Profile).IsUnicode(false);
            entity.Property(e => e.ShortName).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .HasColumnName("URL");
            entity.Property(e => e.Vision).IsUnicode(false);

            entity.HasOne(d => d.CompanySectorDNavigation).WithMany(p => p.Companies)
                .HasForeignKey(d => d.CompanySectorD)
                .HasConstraintName("FK_Companies_CompanySectors");

            entity.HasOne(d => d.CompanyType).WithMany(p => p.Companies)
                .HasForeignKey(d => d.CompanyTypeId)
                .HasConstraintName("FK_Companies_CompanyTypes");

            entity.HasOne(d => d.Country).WithMany(p => p.Companies)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Companies_Countries");
        });

        modelBuilder.Entity<CompanyModule>(entity =>
        {
            entity.HasKey(e => e.ModuleId).HasName("PK__CompanyM__2B747787DFB7C1DE");

            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.ModuleName).HasMaxLength(100);
            entity.Property(e => e.SequenceNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
        });

        modelBuilder.Entity<CompanyProgram>(entity =>
        {
            entity.HasKey(e => e.ProgramId).HasName("PK__CompanyP__752560388837A9C5");

            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ProgramName).HasMaxLength(50);
            entity.Property(e => e.SequenceNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyPrograms)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompanyPrograms_Companies");

            entity.HasOne(d => d.Module).WithMany(p => p.CompanyPrograms)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompanyPrograms_CompanyModules");
        });

        modelBuilder.Entity<CompanySector>(entity =>
        {
            entity.HasKey(e => e.CompanySectorId).HasName("PK__CompanyS__9EE156BE14DD6F3D");

            entity.Property(e => e.CompanySectorId).HasColumnName("CompanySectorID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.ShortName).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
        });

        modelBuilder.Entity<CompanyType>(entity =>
        {
            entity.HasKey(e => e.CompanyTypeId).HasName("PK__CompanyT__06019938D4B306A0");

            entity.Property(e => e.CompanyTypeId).HasColumnName("CompanyTypeID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.ShortName).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
        });

        modelBuilder.Entity<ContractType>(entity =>
        {
            entity.HasKey(e => e.ContractTypeId).HasName("PK__Contract__68A615457B489DFE");

            entity.Property(e => e.ContractTypeId).HasColumnName("ContractTypeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContractType1)
                .HasMaxLength(20)
                .HasColumnName("ContractType");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.ContractTypes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractTypes_Companies");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Countrie__10D160BF05CAFEB4");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.Currency).HasMaxLength(100);
            entity.Property(e => e.CurrencySymbol).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.ShortName).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
        });

        modelBuilder.Entity<Deduction>(entity =>
        {
            entity.HasKey(e => e.DeductionId).HasName("PK__Deductio__E2604C77F46BD559");

            entity.Property(e => e.DeductionId).HasColumnName("DeductionID");
            entity.Property(e => e.AssociateTaxId).HasColumnName("AssociateTaxID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.DeductionMethod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DeductionTypeId).HasColumnName("DeductionTypeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsIncludeInCtc).HasColumnName("IsIncludeInCTC");
            entity.Property(e => e.PaySlipName).HasMaxLength(100);
            entity.Property(e => e.TaxType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.AssociateTax).WithMany(p => p.Deductions)
                .HasForeignKey(d => d.AssociateTaxId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deductions_AssociateTaxes");

            entity.HasOne(d => d.Company).WithMany(p => p.Deductions)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deductions_Companies");

            entity.HasOne(d => d.DeductionType).WithMany(p => p.Deductions)
                .HasForeignKey(d => d.DeductionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deductions_DeductionTypes");
        });

        modelBuilder.Entity<DeductionType>(entity =>
        {
            entity.HasKey(e => e.DeductionTypeId).HasName("PK__Deductio__AEB1B78D144DF866");

            entity.Property(e => e.DeductionTypeId).HasColumnName("DeductionTypeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.DeductionMethod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DeductionType1)
                .HasMaxLength(100)
                .HasColumnName("DeductionType");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsIncludeInCtc).HasColumnName("IsIncludeInCTC");
            entity.Property(e => e.TaxType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.DeductionTypes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeductionTypes_Companies");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BCD0D8F1A7C");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.Department1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Department");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ShortName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Departments)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Departments_Companies");
        });

        modelBuilder.Entity<Designation>(entity =>
        {
            entity.HasKey(e => e.DesignationId).HasName("PK__Designat__BABD603EE28AE02B");

            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.Designation1)
                .HasMaxLength(50)
                .HasColumnName("Designation");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.SequenceNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Designations)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Designations_Companies");
        });

        modelBuilder.Entity<DocumentType>(entity =>
        {
            entity.HasKey(e => e.DocumentTypeId).HasName("PK__Document__DBA390C13E6EAC7C");

            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocumentType1)
                .HasMaxLength(25)
                .HasColumnName("DocumentType");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsCompulsory)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.DocumentTypes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocumentTypes_Companies");
        });

        modelBuilder.Entity<Earning>(entity =>
        {
            entity.HasKey(e => e.EarningId).HasName("PK__Earnings__2418A1C215E350EB");

            entity.Property(e => e.EarningId).HasColumnName("EarningID");
            entity.Property(e => e.CalculationType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EarningTypeId).HasColumnName("EarningTypeID");
            entity.Property(e => e.Epfcontribution)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EPFContribution");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsEsicontribution).HasColumnName("IsESIContribution");
            entity.Property(e => e.IsFbplimitOverride).HasColumnName("IsFBPLimitOverride");
            entity.Property(e => e.IsFbppayroll).HasColumnName("IsFBPPayroll");
            entity.Property(e => e.IsFbpproofRequired).HasColumnName("IsFBPProofRequired");
            entity.Property(e => e.IsIncludeInCtc).HasColumnName("IsIncludeInCTC");
            entity.Property(e => e.PaySlipName).HasMaxLength(1);
            entity.Property(e => e.PayType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TdsdeductMethod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TDSDeductMethod");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Earnings)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Earnings_Companies");

            entity.HasOne(d => d.EarningType).WithMany(p => p.Earnings)
                .HasForeignKey(d => d.EarningTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Earnings_EarningTypes");
        });

        modelBuilder.Entity<EarningType>(entity =>
        {
            entity.HasKey(e => e.EarningTypeId).HasName("PK__EarningT__2C17F13596149BB1");

            entity.Property(e => e.EarningTypeId).HasColumnName("EarningTypeID");
            entity.Property(e => e.CalculationType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EarningType1)
                .HasMaxLength(50)
                .HasColumnName("EarningType");
            entity.Property(e => e.Epfcontribution)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EPFContribution");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsEsicontribution).HasColumnName("IsESIContribution");
            entity.Property(e => e.IsFbplimitOverride).HasColumnName("IsFBPLimitOverride");
            entity.Property(e => e.IsFbppayroll).HasColumnName("IsFBPPayroll");
            entity.Property(e => e.IsFbpproofRequired).HasColumnName("IsFBPProofRequired");
            entity.Property(e => e.IsIncludeInCtc).HasColumnName("IsIncludeInCTC");
            entity.Property(e => e.PayType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TdsdeductMethod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TDSDeductMethod");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.EarningTypes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EarningTypes_Companies");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF11F595136");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedNever()
                .HasColumnName("EmployeeID");
            entity.Property(e => e.Aadhaar).HasMaxLength(10);
            entity.Property(e => e.BloodGroupId).HasColumnName("BloodGroupID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CurrentCityId).HasColumnName("CurrentCityID");
            entity.Property(e => e.CurrentCountryId).HasColumnName("CurrentCountryID");
            entity.Property(e => e.CurrentPincode).HasMaxLength(10);
            entity.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmergencyContactNo).HasMaxLength(10);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Initials).HasMaxLength(5);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.MobileNo).HasMaxLength(15);
            entity.Property(e => e.MobileNo2).HasMaxLength(15);
            entity.Property(e => e.MotherName).HasMaxLength(50);
            entity.Property(e => e.Pan)
                .HasMaxLength(15)
                .HasColumnName("PAN");
            entity.Property(e => e.PermanentCityId).HasColumnName("PermanentCityID");
            entity.Property(e => e.PermanentCountryId).HasColumnName("PermanentCountryID");
            entity.Property(e => e.PermanentPincode).HasMaxLength(10);
            entity.Property(e => e.PermanentStateId).HasColumnName("PermanentStateID");
            entity.Property(e => e.SpouseName).HasMaxLength(50);
            entity.Property(e => e.TitleId).HasColumnName("TitleID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.BloodGroup).WithMany(p => p.Employees)
                .HasForeignKey(d => d.BloodGroupId)
                .HasConstraintName("FK_Employees_BloodGroups");

            entity.HasOne(d => d.Company).WithMany(p => p.Employees)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employees_Companies");

            entity.HasOne(d => d.PermanentCity).WithMany(p => p.Employees)
                .HasForeignKey(d => d.PermanentCityId)
                .HasConstraintName("FK_Employees_Cities");

            entity.HasOne(d => d.PermanentCountry).WithMany(p => p.Employees)
                .HasForeignKey(d => d.PermanentCountryId)
                .HasConstraintName("FK_Employees_Countries");

            entity.HasOne(d => d.PermanentState).WithMany(p => p.Employees)
                .HasForeignKey(d => d.PermanentStateId)
                .HasConstraintName("FK_Employees_States");

            entity.HasOne(d => d.Title).WithMany(p => p.Employees)
                .HasForeignKey(d => d.TitleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employees_Titles");

            entity.HasOne(d => d.User).WithMany(p => p.Employees)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Employees_Users");
        });

        modelBuilder.Entity<EmployeeBank>(entity =>
        {
            entity.HasKey(e => e.EmployeeBankId).HasName("PK__Employee__ADD43A0166BEF6A9");

            entity.ToTable("EmployeeBank");

            entity.Property(e => e.EmployeeBankId).HasColumnName("EmployeeBankID");
            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.AccountNo).HasMaxLength(25);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(11)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.Upiid)
                .HasMaxLength(50)
                .HasColumnName("UPIID");

            entity.HasOne(d => d.Company).WithMany(p => p.EmployeeBanks)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeBank_Companies");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeBanks)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeBank_Employees");
        });

        modelBuilder.Entity<EmployeeCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Employee__19093A2B335809E3");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Category).HasMaxLength(25);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.EmployeeCategories)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeCategories_Companies");
        });

        modelBuilder.Entity<EmployeeDocument>(entity =>
        {
            entity.HasKey(e => e.EmployeeDocumentId).HasName("PK__Employee__FEF7C6E4BB50F9F9");

            entity.Property(e => e.EmployeeDocumentId).HasColumnName("EmployeeDocumentID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.Document).HasMaxLength(25);
            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.SubmitDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.EmployeeDocuments)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeDocuments_Companies");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.EmployeeDocuments)
                .HasForeignKey(d => d.DocumentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeDocuments_DocumentTypes");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeDocuments)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeDocuments_Employees");
        });

        modelBuilder.Entity<EmployeeExperience>(entity =>
        {
            entity.HasKey(e => e.EmployeeExperienceId).HasName("PK__Employee__ADD40C9D47BD8921");

            entity.ToTable("EmployeeExperience");

            entity.Property(e => e.EmployeeExperienceId).HasColumnName("EmployeeExperienceID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(200);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsRelevant)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JobDescription).HasMaxLength(200);
            entity.Property(e => e.JobTitle).HasMaxLength(200);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.EmployeeExperiences)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeExperience_Companies");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeExperiences)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeExperience_Employees");
        });

        modelBuilder.Entity<EmployeeProfile>(entity =>
        {
            entity.HasKey(e => e.EmployeeProfileId).HasName("PK__Employee__7CC01C3EC6FD2492");

            entity.ToTable("EmployeeProfile");

            entity.Property(e => e.EmployeeProfileId).HasColumnName("EmployeeProfileID");
            entity.Property(e => e.AttendancdModeId).HasColumnName("AttendancdModeID");
            entity.Property(e => e.CardId)
                .HasMaxLength(15)
                .HasColumnName("CardID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContractTypeId).HasColumnName("ContractTypeID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Epsexit).HasColumnName("EPSExit");
            entity.Property(e => e.Epsjoining).HasColumnName("EPSJoining");
            entity.Property(e => e.Esinumber)
                .HasMaxLength(20)
                .HasColumnName("ESINumber");
            entity.Property(e => e.GradeId).HasColumnName("GradeID");
            entity.Property(e => e.HolidayTemplateId).HasColumnName("HolidayTemplateID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsEpseligible).HasColumnName("IsEPSEligible");
            entity.Property(e => e.IsEsieligible).HasColumnName("IsESIEligible");
            entity.Property(e => e.IsHpseligible).HasColumnName("IsHPSEligible");
            entity.Property(e => e.IsLwfeligible).HasColumnName("IsLWFEligible");
            entity.Property(e => e.IsPfeligible).HasColumnName("IsPFEligible");
            entity.Property(e => e.IsPteligible).HasColumnName("IsPTEligible");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PfjoinDate).HasColumnName("PFJoinDate");
            entity.Property(e => e.Pfnumber)
                .HasMaxLength(15)
                .HasColumnName("PFNumber");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.WeeklyOffTemplateId).HasColumnName("WeeklyOffTemplateID");
            entity.Property(e => e.WeeklyOffTypeId).HasColumnName("WeeklyOffTypeID");

            entity.HasOne(d => d.AttendancdMode).WithMany(p => p.EmployeeProfiles)
                .HasForeignKey(d => d.AttendancdModeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeProfile_AttendanceModes");

            entity.HasOne(d => d.Category).WithMany(p => p.EmployeeProfiles)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeProfile_EmployeeCategories");

            entity.HasOne(d => d.Company).WithMany(p => p.EmployeeProfiles)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeProfile_Companies");

            entity.HasOne(d => d.ContractType).WithMany(p => p.EmployeeProfiles)
                .HasForeignKey(d => d.ContractTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeProfile_ContractTypes");

            entity.HasOne(d => d.Designation).WithMany(p => p.EmployeeProfiles)
                .HasForeignKey(d => d.DesignationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeProfile_Designations");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeProfiles)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeProfile_Employees");

            entity.HasOne(d => d.Grade).WithMany(p => p.EmployeeProfiles)
                .HasForeignKey(d => d.GradeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeProfile_Grades");

            entity.HasOne(d => d.HolidayTemplate).WithMany(p => p.EmployeeProfiles)
                .HasForeignKey(d => d.HolidayTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeProfile_HolidayTemplates");

            entity.HasOne(d => d.Location).WithMany(p => p.EmployeeProfiles)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeProfile_Locations");

            entity.HasOne(d => d.Role).WithMany(p => p.EmployeeProfiles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeProfile_Roles");

            entity.HasOne(d => d.Shift).WithMany(p => p.EmployeeProfiles)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeProfile_Shifts");

            entity.HasOne(d => d.WeeklyOffTemplate).WithMany(p => p.EmployeeProfiles)
                .HasForeignKey(d => d.WeeklyOffTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeProfile_WeeklyOffTemplates");
        });

        modelBuilder.Entity<EmployeeQualification>(entity =>
        {
            entity.HasKey(e => e.EmployeeQualificationId).HasName("PK__Employee__E618F3BCC36C45B1");

            entity.ToTable("EmployeeQualification");

            entity.Property(e => e.EmployeeQualificationId).HasColumnName("EmployeeQualificationID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Institute).HasMaxLength(200);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Qualification).HasMaxLength(25);
            entity.Property(e => e.QualificationId).HasColumnName("QualificationID");
            entity.Property(e => e.Specialization).HasMaxLength(200);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.EmployeeQualifications)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeQualification_Companies");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeQualifications)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeQualification_Employees");

            entity.HasOne(d => d.QualificationNavigation).WithMany(p => p.EmployeeQualifications)
                .HasForeignKey(d => d.QualificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeQualification_Qualifications");
        });

        modelBuilder.Entity<ExitType>(entity =>
        {
            entity.HasKey(e => e.ExitTypeId).HasName("PK__ExitType__EF3F71FE7A6A9DFA");

            entity.Property(e => e.ExitTypeId).HasColumnName("ExitTypeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.ExitType1)
                .HasMaxLength(50)
                .HasColumnName("ExitType");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.ExitTypes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExitTypes_Companies");
        });

        modelBuilder.Entity<ExpenseClaim>(entity =>
        {
            entity.HasKey(e => e.ClaimId).HasName("PK__ExpenseC__EF2E13BBEC13C3E7");

            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");
            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.ClaimDate).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.ExpenseTypeId).HasColumnName("ExpenseTypeID");
            entity.Property(e => e.FileUploadDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.Reason).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Application).WithMany(p => p.ExpenseClaims)
                .HasForeignKey(d => d.ApplicationId)
                .HasConstraintName("FK_ExpenseClaims_AdvanceApplications");

            entity.HasOne(d => d.Company).WithMany(p => p.ExpenseClaims)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExpenseClaims_Companies");

            entity.HasOne(d => d.Employee).WithMany(p => p.ExpenseClaims)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExpenseClaims_Employees");

            entity.HasOne(d => d.ExpenseType).WithMany(p => p.ExpenseClaims)
                .HasForeignKey(d => d.ExpenseTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExpenseClaims_ExpenseTypes");

            entity.HasOne(d => d.Month).WithMany(p => p.ExpenseClaims)
                .HasForeignKey(d => d.MonthId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExpenseClaims_Months");
        });

        modelBuilder.Entity<ExpenseType>(entity =>
        {
            entity.HasKey(e => e.ExpenseTypeId).HasName("PK__ExpenseT__E082A36FE49D237B");

            entity.Property(e => e.ExpenseTypeId).HasColumnName("ExpenseTypeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpenseType1)
                .HasMaxLength(50)
                .HasColumnName("ExpenseType");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.ExpenseTypes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExpenseTypes_Companies");
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.GradeId).HasName("PK__Grades__54F87A37E3E4DDD9");

            entity.Property(e => e.GradeId).HasColumnName("GradeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.Grade1)
                .HasMaxLength(10)
                .HasColumnName("Grade");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.SequenceNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Grades)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Grades_Companies");
        });

        modelBuilder.Entity<HolidayTemplate>(entity =>
        {
            entity.HasKey(e => e.HolidayTemplateId).HasName("PK__HolidayT__7E18EE2C59F7E72F");

            entity.Property(e => e.HolidayTemplateId).HasColumnName("HolidayTemplateID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Company).WithMany(p => p.HolidayTemplates)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HolidayTemplates_Companies");

            entity.HasOne(d => d.Year).WithMany(p => p.HolidayTemplates)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HolidayTemplates_Years");
        });

        modelBuilder.Entity<HolidayTemplateDay>(entity =>
        {
            entity.HasKey(e => e.DaysId).HasName("PK__HolidayT__BCE474CB800A22D6");

            entity.Property(e => e.DaysId).HasColumnName("DaysID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.HolidayTemplateId).HasColumnName("HolidayTemplateID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.HolidayTemplateDays)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HolidayTemplateDays_Companies");

            entity.HasOne(d => d.HolidayTemplate).WithMany(p => p.HolidayTemplateDays)
                .HasForeignKey(d => d.HolidayTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HolidayTemplateDays_HolidayTemplates");
        });

        modelBuilder.Entity<LeaveApplication>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("PK__LeaveApp__C93A4F79007C0A18");

            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.ApplicationNo).HasMaxLength(10);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.Reason).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Company).WithMany(p => p.LeaveApplications)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveApplications_Companies");

            entity.HasOne(d => d.Employee).WithMany(p => p.LeaveApplications)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveApplications_Employees");

            entity.HasOne(d => d.LeaveType).WithMany(p => p.LeaveApplications)
                .HasForeignKey(d => d.LeaveTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveApplications_LeaveTypes");

            entity.HasOne(d => d.Year).WithMany(p => p.LeaveApplications)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveApplications_Years");
        });

        modelBuilder.Entity<LeaveApplicationDetail>(entity =>
        {
            entity.HasKey(e => e.ApplicationDetailId).HasName("PK__LeaveApp__DBC6C3F98058B9CF");

            entity.Property(e => e.ApplicationDetailId).HasColumnName("ApplicationDetailID");
            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.Duration)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Application).WithMany(p => p.LeaveApplicationDetails)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveApplicationDetails_LeaveApplications");

            entity.HasOne(d => d.Company).WithMany(p => p.LeaveApplicationDetails)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveApplicationDetails_Companies");
        });

        modelBuilder.Entity<LeaveBalance>(entity =>
        {
            entity.HasKey(e => e.BalanceId).HasName("PK__LeaveBal__A760D59E9CA4FD7E");

            entity.Property(e => e.BalanceId).HasColumnName("BalanceID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Company).WithMany(p => p.LeaveBalances)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveBalances_Companies");

            entity.HasOne(d => d.Year).WithMany(p => p.LeaveBalances)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveBalances_Years");
        });

        modelBuilder.Entity<LeaveType>(entity =>
        {
            entity.HasKey(e => e.LeaveTypeId).HasName("PK__LeaveTyp__43BE8FF455AAD2BF");

            entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");
            entity.Property(e => e.ApplicableTo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsCarryForward)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsEncash)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LeaveCategory)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LeaveCode).HasMaxLength(5);
            entity.Property(e => e.LeavePeriod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LeaveType1)
                .HasMaxLength(50)
                .HasColumnName("LeaveType");
            entity.Property(e => e.PostponeBy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ResetPeriod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.LeaveTypes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveTypes_Companies");
        });

        modelBuilder.Entity<LoanApplication>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("PK__LoanAppl__C93A4F79321E11A9");

            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.ApplicationNo).HasMaxLength(10);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.Emiamount).HasColumnName("EMIAmount");
            entity.Property(e => e.EmistartDate).HasColumnName("EMIStartDate");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LoanTypeId).HasColumnName("LoanTypeID");
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.Reason).HasMaxLength(200);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Company).WithMany(p => p.LoanApplications)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoanApplications_Companies");

            entity.HasOne(d => d.Employee).WithMany(p => p.LoanApplications)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoanApplications_Employees");

            entity.HasOne(d => d.LoanType).WithMany(p => p.LoanApplications)
                .HasForeignKey(d => d.LoanTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoanApplications_LoanTypes");
        });

        modelBuilder.Entity<LoanDetail>(entity =>
        {
            entity.HasKey(e => e.LoanDetailId).HasName("PK__LoanDeta__760C1028A6CACCFA");

            entity.Property(e => e.LoanDetailId).HasColumnName("LoanDetailID");
            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Application).WithMany(p => p.LoanDetails)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoanDetails_LoanApplications");

            entity.HasOne(d => d.Company).WithMany(p => p.LoanDetails)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoanDetails_Companies");

            entity.HasOne(d => d.Month).WithMany(p => p.LoanDetails)
                .HasForeignKey(d => d.MonthId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoanDetails_Months");

            entity.HasOne(d => d.Year).WithMany(p => p.LoanDetails)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoanDetails_Years");
        });

        modelBuilder.Entity<LoanType>(entity =>
        {
            entity.HasKey(e => e.LoanTypeId).HasName("PK__LoanType__19466B4FAAF5AD75");

            entity.Property(e => e.LoanTypeId).HasColumnName("LoanTypeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LoanType1)
                .HasMaxLength(50)
                .HasColumnName("LoanType");
            entity.Property(e => e.PerquisiteRate).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.LoanTypes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoanTypes_Companies");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__Location__E7FEA4779394F69E");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Address1).HasMaxLength(100);
            entity.Property(e => e.Address2).HasMaxLength(100);
            entity.Property(e => e.Address3).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Location1)
                .HasMaxLength(100)
                .HasColumnName("Location");
            entity.Property(e => e.Pincode).HasMaxLength(10);
            entity.Property(e => e.ShortName).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Locations)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Locations_Companies");
        });

        modelBuilder.Entity<Month>(entity =>
        {
            entity.HasKey(e => e.MonthId).HasName("PK__Months__9FA83F86E892F3C8");

            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.ApprovedById).HasColumnName("ApprovedByID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsOpen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Month1)
                .HasMaxLength(20)
                .HasColumnName("Month");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Company).WithMany(p => p.Months)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Months_Companies");

            entity.HasOne(d => d.Year).WithMany(p => p.Months)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Months_Years");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK__Notifica__20CF2E32FF4982BF");

            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.NotificationType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SentAt).HasColumnType("datetime");
            entity.Property(e => e.TaskId).HasColumnName("TaskID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notifications_Companies");

            entity.HasOne(d => d.Employee).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notifications_Employees");

            entity.HasOne(d => d.Task).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notifications_Tasks");
        });

        modelBuilder.Entity<OvertimeApplication>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("PK__Overtime__C93A4F79B70CDF1F");

            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.ApplicationNo).HasMaxLength(10);
            entity.Property(e => e.ApprovedById).HasColumnName("ApprovedByID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.Reason).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Company).WithMany(p => p.OvertimeApplications)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OvertimeApplications_Companies");

            entity.HasOne(d => d.Employee).WithMany(p => p.OvertimeApplications)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OvertimeApplications_Employees");

            entity.HasOne(d => d.Month).WithMany(p => p.OvertimeApplications)
                .HasForeignKey(d => d.MonthId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OvertimeApplications_Months");

            entity.HasOne(d => d.Year).WithMany(p => p.OvertimeApplications)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OvertimeApplications_Years");
        });

        modelBuilder.Entity<OvertimePolicy>(entity =>
        {
            entity.HasKey(e => e.PolicyId).HasName("PK__Overtime__2E133944B98B9309");

            entity.Property(e => e.PolicyId).HasColumnName("PolicyID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Category).WithMany(p => p.OvertimePolicies)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OvertimePolicies_EmployeeCategories");

            entity.HasOne(d => d.Company).WithMany(p => p.OvertimePolicies)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OvertimePolicies_Companies");
        });

        modelBuilder.Entity<Payroll>(entity =>
        {
            entity.HasKey(e => e.PayrollId).HasName("PK__Payrolls__99DFC692D34C6FF6");

            entity.Property(e => e.PayrollId).HasColumnName("PayrollID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PaymentReference).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Company).WithMany(p => p.Payrolls)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payrolls_Companies");

            entity.HasOne(d => d.Employee).WithMany(p => p.Payrolls)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payrolls_Employees");

            entity.HasOne(d => d.Month).WithMany(p => p.Payrolls)
                .HasForeignKey(d => d.MonthId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payrolls_Months");

            entity.HasOne(d => d.Year).WithMany(p => p.Payrolls)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payrolls_Years");
        });

        modelBuilder.Entity<PayrollDeduction>(entity =>
        {
            entity.HasKey(e => e.PayrollDeductionId).HasName("PK__PayrollD__FBDF01B2F2CE3561");

            entity.Property(e => e.PayrollDeductionId).HasColumnName("PayrollDeductionID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.DeductionId).HasColumnName("DeductionID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.PayrollId).HasColumnName("PayrollID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.PayrollDeductions)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollDeductions_Companies");

            entity.HasOne(d => d.Deduction).WithMany(p => p.PayrollDeductions)
                .HasForeignKey(d => d.DeductionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollDeductions_Deductions");

            entity.HasOne(d => d.Payroll).WithMany(p => p.PayrollDeductions)
                .HasForeignKey(d => d.PayrollId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollDeductions_Payrolls");
        });

        modelBuilder.Entity<PayrollEarning>(entity =>
        {
            entity.HasKey(e => e.PayrollEarningId).HasName("PK__PayrollE__6DCA11CD3520F6C9");

            entity.Property(e => e.PayrollEarningId).HasColumnName("PayrollEarningID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EarningId).HasColumnName("EarningID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.PayrollId).HasColumnName("PayrollID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.PayrollEarnings)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollEarnings_Companies");

            entity.HasOne(d => d.Earning).WithMany(p => p.PayrollEarnings)
                .HasForeignKey(d => d.EarningId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollEarnings_Earnings");

            entity.HasOne(d => d.Payroll).WithMany(p => p.PayrollEarnings)
                .HasForeignKey(d => d.PayrollId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollEarnings_Payrolls");
        });

        modelBuilder.Entity<PayrollReimbursement>(entity =>
        {
            entity.HasKey(e => e.PayrollReimbursementId).HasName("PK__PayrollR__A73DAEEED68660C4");

            entity.Property(e => e.PayrollReimbursementId).HasColumnName("PayrollReimbursementID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.PayrollId).HasColumnName("PayrollID");
            entity.Property(e => e.ReimbursementId).HasColumnName("ReimbursementID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.PayrollReimbursements)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollReimbursements_Companies");

            entity.HasOne(d => d.Payroll).WithMany(p => p.PayrollReimbursements)
                .HasForeignKey(d => d.PayrollId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollReimbursements_Payrolls");

            entity.HasOne(d => d.Reimbursement).WithMany(p => p.PayrollReimbursements)
                .HasForeignKey(d => d.ReimbursementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollReimbursements_Reimbursements");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.ProfileId).HasName("PK__Profiles__290C888408B8BA3D");

            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Profile1)
                .HasMaxLength(20)
                .HasColumnName("Profile");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Profiles)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Profiles_Companies");
        });

        modelBuilder.Entity<ProfilePrivilege>(entity =>
        {
            entity.HasKey(e => e.PrivilegeId).HasName("PK__ProfileP__B3E77E3C05614F47");

            entity.Property(e => e.PrivilegeId).HasColumnName("PrivilegeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.ProfilePrivileges)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfilePrivileges_Companies");

            entity.HasOne(d => d.Module).WithMany(p => p.ProfilePrivileges)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfilePrivileges_SystemModules");

            entity.HasOne(d => d.Profile).WithMany(p => p.ProfilePrivileges)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfilePrivileges_Profiles");

            entity.HasOne(d => d.Program).WithMany(p => p.ProfilePrivileges)
                .HasForeignKey(d => d.ProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfilePrivileges_SystemPrograms");
        });

        modelBuilder.Entity<Qualification>(entity =>
        {
            entity.HasKey(e => e.QualificationId).HasName("PK__Qualific__C95C128A7248D457");

            entity.Property(e => e.QualificationId).HasColumnName("QualificationID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Qualification1)
                .HasMaxLength(25)
                .HasColumnName("Qualification");
            entity.Property(e => e.ShortName).HasMaxLength(25);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Qualifications)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Qualifications_Companies");
        });

        modelBuilder.Entity<Reimbursement>(entity =>
        {
            entity.HasKey(e => e.ReimbursementId).HasName("PK__Reimburs__FD1BC7A0F7EA0904");

            entity.Property(e => e.ReimbursementId).HasColumnName("ReimbursementID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsIncludeFbp).HasColumnName("IsIncludeFBP");
            entity.Property(e => e.ReimbursementAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ReimbursementType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ReimbursementTypeId).HasColumnName("ReimbursementTypeID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Reimbursements)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reimbursements_Companies");

            entity.HasOne(d => d.ReimbursementTypeNavigation).WithMany(p => p.Reimbursements)
                .HasForeignKey(d => d.ReimbursementTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reimbursements_ReimbursementTypes");
        });

        modelBuilder.Entity<ReimbursementType>(entity =>
        {
            entity.HasKey(e => e.ReimbursementTypeId).HasName("PK__Reimburs__4621B3338D2354E5");

            entity.Property(e => e.ReimbursementTypeId).HasColumnName("ReimbursementTypeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsIncludeFbp).HasColumnName("IsIncludeFBP");
            entity.Property(e => e.ReimbursementAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ReimbursementMethod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ReimbursementType1)
                .HasMaxLength(100)
                .HasColumnName("ReimbursementType");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.ReimbursementTypes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReimbursementTypes_Companies");
        });

        modelBuilder.Entity<ResignationApplication>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("PK__Resignat__C93A4F798D521121");

            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.ApplicationNo).HasMaxLength(10);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.ExitTypeId).HasColumnName("ExitTypeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.Reason).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Company).WithMany(p => p.ResignationApplications)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ResignationApplications_Companies");

            entity.HasOne(d => d.Employee).WithMany(p => p.ResignationApplications)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ResignationApplications_Employees");

            entity.HasOne(d => d.ExitType).WithMany(p => p.ResignationApplications)
                .HasForeignKey(d => d.ExitTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ResignationApplications_ExitTypes");

            entity.HasOne(d => d.Month).WithMany(p => p.ResignationApplications)
                .HasForeignKey(d => d.MonthId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ResignationApplications_Months");

            entity.HasOne(d => d.Year).WithMany(p => p.ResignationApplications)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ResignationApplications_Years");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE3AA1FC7877");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsCeo).HasColumnName("IsCEO");
            entity.Property(e => e.ParentRoleId).HasColumnName("ParentRoleID");
            entity.Property(e => e.Role1)
                .HasMaxLength(20)
                .HasColumnName("Role");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Roles)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Roles_Companies");

            entity.HasOne(d => d.ParentRole).WithMany(p => p.InverseParentRole)
                .HasForeignKey(d => d.ParentRoleId)
                .HasConstraintName("FK_Roles_Roles");
        });

        modelBuilder.Entity<Roster>(entity =>
        {
            entity.HasKey(e => e.RosterId).HasName("PK__Rosters__66F6BAAAEFA32D8F");

            entity.Property(e => e.RosterId).HasColumnName("RosterID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.RosterPeriod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Company).WithMany(p => p.Rosters)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rosters_Companies");

            entity.HasOne(d => d.Location).WithMany(p => p.Rosters)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rosters_Locations");

            entity.HasOne(d => d.Year).WithMany(p => p.Rosters)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rosters_Years");
        });

        modelBuilder.Entity<RosterDetail>(entity =>
        {
            entity.HasKey(e => e.RosterDetailId).HasName("PK__RosterDe__163A010D8D9EE310");

            entity.Property(e => e.RosterDetailId)
                .ValueGeneratedNever()
                .HasColumnName("RosterDetailID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.Day).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.RosterId).HasColumnName("RosterID");
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.RosterDetails)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RosterDetails_Companies");

            entity.HasOne(d => d.Employee).WithMany(p => p.RosterDetails)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RosterDetails_Employees");

            entity.HasOne(d => d.Shift).WithMany(p => p.RosterDetails)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RosterDetails_Shifts");
        });

        modelBuilder.Entity<SalaryDeduction>(entity =>
        {
            entity.HasKey(e => e.SalayDeductionId).HasName("PK__SalaryDe__94B48BCE58815CC9");

            entity.Property(e => e.SalayDeductionId).HasColumnName("SalayDeductionID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.DeductionId).HasColumnName("DeductionID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.SalaryTemplateId).HasColumnName("SalaryTemplateID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
        });

        modelBuilder.Entity<SalaryEarning>(entity =>
        {
            entity.HasKey(e => e.SalaryEarningId).HasName("PK__SalaryEa__A38C0B4D15D250C1");

            entity.Property(e => e.SalaryEarningId).HasColumnName("SalaryEarningID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EarningId).HasColumnName("EarningID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.SalaryTemplateId).HasColumnName("SalaryTemplateID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.SalaryEarnings)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryEarnings_Companies");

            entity.HasOne(d => d.Earning).WithMany(p => p.SalaryEarnings)
                .HasForeignKey(d => d.EarningId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryEarnings_Earnings");
        });

        modelBuilder.Entity<SalaryReimbursement>(entity =>
        {
            entity.HasKey(e => e.SalaryReimbursementId).HasName("PK__SalaryRe__3B5D2F894D50861D");

            entity.Property(e => e.SalaryReimbursementId).HasColumnName("SalaryReimbursementID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ReimbursementId).HasColumnName("ReimbursementID");
            entity.Property(e => e.SalaryTemplateId).HasColumnName("SalaryTemplateID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.SalaryReimbursements)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryReimbursements_Companies");

            entity.HasOne(d => d.Reimbursement).WithMany(p => p.SalaryReimbursements)
                .HasForeignKey(d => d.ReimbursementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryReimbursements_Reimbursements");

            entity.HasOne(d => d.SalaryTemplate).WithMany(p => p.SalaryReimbursements)
                .HasForeignKey(d => d.SalaryTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryReimbursements_SalaryTemplates");
        });

        modelBuilder.Entity<SalaryTemplate>(entity =>
        {
            entity.HasKey(e => e.SalaryTemplateId).HasName("PK__SalaryTe__EF7FA8DF0B56D6E8");

            entity.Property(e => e.SalaryTemplateId).HasColumnName("SalaryTemplateID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.Ctcamount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("CTCAmount");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.SalaryTemplates)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryTemplates_Companies");
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.HasKey(e => e.ShiftId).HasName("PK__Shifts__C0A838E1CE5A237D");

            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.SequenceNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ShiftName).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Shifts)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shifts_Companies");

            entity.HasOne(d => d.Location).WithMany(p => p.Shifts)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shifts_Locations");
        });

        modelBuilder.Entity<ShiftDetail>(entity =>
        {
            entity.HasKey(e => e.ShiftDetailId).HasName("PK__ShiftDet__337A925E14CC7BB7");

            entity.Property(e => e.ShiftDetailId).HasColumnName("ShiftDetailID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EndTimeFormat)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.SequenceNo).HasDefaultValue(1);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.StartTimeFormat)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.ShiftDetails)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShiftDetails_Companies");

            entity.HasOne(d => d.Shift).WithMany(p => p.ShiftDetails)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShiftDetails_Shifts");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__States__C3BA3B5AAE24E357");

            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.ShortName).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Country).WithMany(p => p.States)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_States_Countries");
        });

        modelBuilder.Entity<Statutory>(entity =>
        {
            entity.HasKey(e => e.StatutoryId).HasName("PK__Statutor__61B28A0A25E04473");

            entity.Property(e => e.StatutoryId).HasColumnName("StatutoryID");
            entity.Property(e => e.ApplicableStateId).HasColumnName("ApplicableStateID");
            entity.Property(e => e.BonusMonthlyPercent).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.BonusPaymentFrequency)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.DeductionCycle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmployeeContributionRate).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.EmployerContributionRate).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsAutoStopForSalaryAbove)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsDeductEndContribution)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsEligibleForAbry).HasColumnName("IsEligibleForABRY");
            entity.Property(e => e.IsIncludeAdminInCtc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IsIncludeAdminInCTC");
            entity.Property(e => e.IsIncludeEmployerContriInCtc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IsIncludeEmployerContriInCTC");
            entity.Property(e => e.IsIncludeInCtc).HasColumnName("IsIncludeInCTC");
            entity.Property(e => e.IsLopappliedProRete).HasColumnName("IsLOPAppliedProRete");
            entity.Property(e => e.IsOverridePfcontribution).HasColumnName("IsOverridePFContribution");
            entity.Property(e => e.IsSlabApplicable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.StatutoryNumber).HasMaxLength(10);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Statutories)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Statutories_Companies");
        });

        modelBuilder.Entity<StatutorySlab>(entity =>
        {
            entity.HasKey(e => e.StatutorySlabId).HasName("PK__Statutor__352E362377F1D2C6");

            entity.Property(e => e.StatutorySlabId).HasColumnName("StatutorySlabID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EndRange).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ExceptionMonthAmount).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.GenderApplicable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MonthlyTaxAmount).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.StartRange).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.StatutoryId).HasColumnName("StatutoryID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.StatutorySlabs)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StatutorySlabs_Companies");

            entity.HasOne(d => d.Statutory).WithMany(p => p.StatutorySlabs)
                .HasForeignKey(d => d.StatutoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StatutorySlabs_Statutories");
        });

        modelBuilder.Entity<SystemModule>(entity =>
        {
            entity.HasKey(e => e.ModuleId).HasName("PK__SystemMo__2B747787EEA18729");

            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModuleName).HasMaxLength(100);
            entity.Property(e => e.SequenceNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.SystemModules)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SystemModules_Companies");
        });

        modelBuilder.Entity<SystemProgram>(entity =>
        {
            entity.HasKey(e => e.ProgramId).HasName("PK__SystemPr__7525603804B17BBC");

            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ProgramName).HasMaxLength(50);
            entity.Property(e => e.SequenceNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Module).WithMany(p => p.SystemPrograms)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SystemPrograms_SystemModules");
        });

        modelBuilder.Entity<Domain.Models.Task>(entity =>
        {
            entity.HasKey(e => e.TaskId).HasName("PK__Tasks__7C6949D14BB1C55E");

            entity.Property(e => e.TaskId).HasColumnName("TaskID");
            entity.Property(e => e.AssignedToId).HasColumnName("AssignedToID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.Priority)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TaskDate).HasColumnType("datetime");
            entity.Property(e => e.TaskName).HasMaxLength(200);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Company).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tasks_Companies");

            entity.HasOne(d => d.Month).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.MonthId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tasks_Months");

            entity.HasOne(d => d.Year).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tasks_Years");
        });

        modelBuilder.Entity<TaskAttachment>(entity =>
        {
            entity.HasKey(e => e.AttachmentId).HasName("PK__TaskAtta__442C64DEEF8EC419");

            entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.StatusDate).HasColumnType("datetime");
            entity.Property(e => e.TaskId).HasColumnName("TaskID");
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.TaskAttachments)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskAttachments_Companies");

            entity.HasOne(d => d.Task).WithMany(p => p.TaskAttachments)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskAttachments_Tasks");
        });

        modelBuilder.Entity<TaskHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK__TaskHist__4D7B4ADD37B8B9E0");

            entity.Property(e => e.HistoryId).HasColumnName("HistoryID");
            entity.Property(e => e.Comment).HasMaxLength(200);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StatusDate).HasColumnType("datetime");
            entity.Property(e => e.TaskId).HasColumnName("TaskID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.TaskHistories)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskHistories_Companies");

            entity.HasOne(d => d.Task).WithMany(p => p.TaskHistories)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskHistories_Tasks");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.TeamId).HasName("PK__Teams__123AE7B9B4FE3683");

            entity.Property(e => e.TeamId).HasColumnName("TeamID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Teams)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Teams_Companies");
        });

        modelBuilder.Entity<TeamMember>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__TeamMemb__0CF04B38E4156C17");

            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(100)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.TeamId).HasColumnName("TeamID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.TeamMembers)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeamMembers_Companies");

            entity.HasOne(d => d.Team).WithMany(p => p.TeamMembers)
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeamMembers_Teams");
        });

        modelBuilder.Entity<Tickit>(entity =>
        {
            entity.HasKey(e => e.TickitId).HasName("PK__Tickits__2D14FD487E27BF19");

            entity.Property(e => e.TickitId).HasColumnName("TickitID");
            entity.Property(e => e.AssignedToUserId).HasColumnName("AssignedToUserID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TickitTypeId).HasColumnName("TickitTypeID");
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Tickits)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tickits_Companies");

            entity.HasOne(d => d.Employee).WithMany(p => p.Tickits)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tickits_Employees");

            entity.HasOne(d => d.TickitType).WithMany(p => p.Tickits)
                .HasForeignKey(d => d.TickitTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tickits_TickitTypes");
        });

        modelBuilder.Entity<TickitAttachment>(entity =>
        {
            entity.HasKey(e => e.AttachmentId).HasName("PK__TickitAt__442C64DE972F9B01");

            entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.TickitId).HasColumnName("TickitID");
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.TickitAttachments)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TickitAttachments_Companies");

            entity.HasOne(d => d.Tickit).WithMany(p => p.TickitAttachments)
                .HasForeignKey(d => d.TickitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TickitAttachments_Tickits");
        });

        modelBuilder.Entity<TickitType>(entity =>
        {
            entity.HasKey(e => e.TickitTypeId).HasName("PK__TickitTy__4482A3CD90CE7CAB");

            entity.Property(e => e.TickitTypeId).HasColumnName("TickitTypeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.TickitType1)
                .HasMaxLength(50)
                .HasColumnName("TickitType");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.TickitTypes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TickitTypes_Companies");
        });

        modelBuilder.Entity<Title>(entity =>
        {
            entity.HasKey(e => e.TitleId).HasName("PK__Titles__757589E64C7AB143");

            entity.Property(e => e.TitleId).HasColumnName("TitleID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ShortName).HasMaxLength(5);
            entity.Property(e => e.Title1)
                .HasMaxLength(25)
                .HasColumnName("Title");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Titles)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Titles_Companies");
        });

        modelBuilder.Entity<Udf>(entity =>
        {
            entity.HasKey(e => e.Udfid).HasName("PK__UDF__2C2E08A445C276F4");

            entity.ToTable("UDF");

            entity.Property(e => e.Udfid).HasColumnName("UDFID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FieldName).HasMaxLength(20);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsRequired)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Udfs)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UDF_Companies");

            entity.HasOne(d => d.Program).WithMany(p => p.Udfs)
                .HasForeignKey(d => d.ProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UDF_CompanyPrograms");
        });

        modelBuilder.Entity<Udfdatum>(entity =>
        {
            entity.HasKey(e => e.UdfdataId).HasName("PK__UDFData__921F2E337737D026");

            entity.ToTable("UDFData");

            entity.Property(e => e.UdfdataId).HasColumnName("UDFDataID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.FieldName).HasMaxLength(20);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsRequired)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Udfid).HasColumnName("UDFID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Udfdata)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UDFData_Companies");

            entity.HasOne(d => d.Program).WithMany(p => p.Udfdata)
                .HasForeignKey(d => d.ProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UDFData_CompanyPrograms");

            entity.HasOne(d => d.Udf).WithMany(p => p.Udfdata)
                .HasForeignKey(d => d.Udfid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UDFData_UDF");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC2062DB25");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FirstName).HasMaxLength(25);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LastName).HasMaxLength(25);
            entity.Property(e => e.Login).HasMaxLength(25);
            entity.Property(e => e.MobileNo).HasMaxLength(10);
            entity.Property(e => e.Password).HasMaxLength(25);
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");

            entity.HasOne(d => d.Company).WithMany(p => p.Users)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Companies");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Roles");
        });

        modelBuilder.Entity<WeeklyOffTemplate>(entity =>
        {
            entity.HasKey(e => e.WeeklyOffTemplateId).HasName("PK__WeeklyOf__BB9976ADDA22902A");

            entity.Property(e => e.WeeklyOffTemplateId).HasColumnName("WeeklyOffTemplateID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearId).HasColumnName("YearID");

            entity.HasOne(d => d.Company).WithMany(p => p.WeeklyOffTemplates)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WeeklyOffTemplates_Companies");

            entity.HasOne(d => d.Year).WithMany(p => p.WeeklyOffTemplates)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WeeklyOffTemplates_Years");
        });

        modelBuilder.Entity<WeeklyOffTemplateDay>(entity =>
        {
            entity.HasKey(e => e.DayId).HasName("PK__WeeklyOf__BF3DD825CF6CE216");

            entity.Property(e => e.DayId).HasColumnName("DayID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreareLoginId).HasColumnName("CreareLoginID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DayName).HasMaxLength(20);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.WeeklyOffTemplateId).HasColumnName("WeeklyOffTemplateID");

            entity.HasOne(d => d.Company).WithMany(p => p.WeeklyOffTemplateDays)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WeeklyOffTemplateDays_Companies");

            entity.HasOne(d => d.WeeklyOffTemplate).WithMany(p => p.WeeklyOffTemplateDays)
                .HasForeignKey(d => d.WeeklyOffTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WeeklyOffTemplateDays_WeeklyOffTemplates");
        });

        modelBuilder.Entity<Year>(entity =>
        {
            entity.HasKey(e => e.YearId).HasName("PK__Years__C33A18ADF37D8A73");

            entity.Property(e => e.YearId).HasColumnName("YearID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateLoginId).HasColumnName("CreateLoginID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsOpen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateLoginId).HasColumnName("UpdateLoginID");
            entity.Property(e => e.YearLabel).HasMaxLength(15);

            entity.HasOne(d => d.Company).WithMany(p => p.Years)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Years_Companies");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
