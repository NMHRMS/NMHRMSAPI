using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class PayrollEarning
{
    public int CompanyId { get; set; }

    public int PayrollEarningId { get; set; }

    public int PayrollId { get; set; }

    public int EarningId { get; set; }

    public double EarningAmount { get; set; }

    public double EarnedAmount { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Earning Earning { get; set; } = null!;

    public virtual Payroll Payroll { get; set; } = null!;
}
