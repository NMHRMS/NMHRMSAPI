using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Year
{
    public int CompanyId { get; set; }

    public int YearId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string YearLabel { get; set; } = null!;

    public string IsOpen { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<AdvanceApplication> AdvanceApplications { get; set; } = new List<AdvanceApplication>();

    public virtual ICollection<AssetAllotment> AssetAllotments { get; set; } = new List<AssetAllotment>();

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<HolidayTemplate> HolidayTemplates { get; set; } = new List<HolidayTemplate>();

    public virtual ICollection<LeaveApplication> LeaveApplications { get; set; } = new List<LeaveApplication>();

    public virtual ICollection<LeaveBalance> LeaveBalances { get; set; } = new List<LeaveBalance>();

    public virtual ICollection<LoanDetail> LoanDetails { get; set; } = new List<LoanDetail>();

    public virtual ICollection<Month> Months { get; set; } = new List<Month>();

    public virtual ICollection<OvertimeApplication> OvertimeApplications { get; set; } = new List<OvertimeApplication>();

    public virtual ICollection<Payroll> Payrolls { get; set; } = new List<Payroll>();

    public virtual ICollection<ResignationApplication> ResignationApplications { get; set; } = new List<ResignationApplication>();

    public virtual ICollection<Roster> Rosters { get; set; } = new List<Roster>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

    public virtual ICollection<WeeklyOffTemplate> WeeklyOffTemplates { get; set; } = new List<WeeklyOffTemplate>();
}
