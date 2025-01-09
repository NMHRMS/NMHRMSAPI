using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class AssetAllotment
{
    public int CompanyId { get; set; }

    public int YearId { get; set; }

    public int MonthId { get; set; }

    public int AllotmentId { get; set; }

    public int AssetId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime AllotmentDate { get; set; }

    public int AllotedById { get; set; }

    public DateTime? ReturnDate { get; set; }

    public bool ConditionOnReturn { get; set; }

    public string? Note { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual Company Company { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual Month Month { get; set; } = null!;

    public virtual Year Year { get; set; } = null!;
}
