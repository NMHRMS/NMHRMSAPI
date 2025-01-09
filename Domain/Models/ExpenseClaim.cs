using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class ExpenseClaim
{
    public int CompanyId { get; set; }

    public int YearId { get; set; }

    public int MonthId { get; set; }

    public int? ApplicationId { get; set; }

    public int EmployeeId { get; set; }

    public int ClaimId { get; set; }

    public DateTime ClaimDate { get; set; }

    public int ExpenseTypeId { get; set; }

    public double RequestAmount { get; set; }

    public string? Reason { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly? ApprovedDate { get; set; }

    public string? ExpnenseFilePath { get; set; }

    public DateTime? FileUploadDate { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreareLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual AdvanceApplication? Application { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual ExpenseType ExpenseType { get; set; } = null!;

    public virtual Month Month { get; set; } = null!;
}
