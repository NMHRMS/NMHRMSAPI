using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class ResignationApplication
{
    public int CompanyId { get; set; }

    public int YearId { get; set; }

    public int MonthId { get; set; }

    public int ApplicationId { get; set; }

    public string ApplicationNo { get; set; } = null!;

    public DateOnly ApplicationDate { get; set; }

    public int ExitTypeId { get; set; }

    public int EmployeeId { get; set; }

    public string Reason { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int NoticePeriod { get; set; }

    public DateOnly? RelivingDate { get; set; }

    public bool IsAssetsReturned { get; set; }

    public bool IsFinalSettlement { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual ExitType ExitType { get; set; } = null!;

    public virtual Month Month { get; set; } = null!;

    public virtual Year Year { get; set; } = null!;
}
