using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Month
{
    public int CompanyId { get; set; }

    public int MonthId { get; set; }

    public string Month1 { get; set; } = null!;

    public int YearId { get; set; }

    public int? WorkingDays { get; set; }

    public int? MonthDays { get; set; }

    public string? Remarks { get; set; }

    public bool IsApproved { get; set; }

    public int? ApprovedById { get; set; }

    public string IsOpen { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<AssetAllotment> AssetAllotments { get; set; } = new List<AssetAllotment>();

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<ExpenseClaim> ExpenseClaims { get; set; } = new List<ExpenseClaim>();

    public virtual ICollection<LoanDetail> LoanDetails { get; set; } = new List<LoanDetail>();

    public virtual ICollection<OvertimeApplication> OvertimeApplications { get; set; } = new List<OvertimeApplication>();

    public virtual ICollection<Payroll> Payrolls { get; set; } = new List<Payroll>();

    public virtual ICollection<ResignationApplication> ResignationApplications { get; set; } = new List<ResignationApplication>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

    public virtual Year Year { get; set; } = null!;
}
