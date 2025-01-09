using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class PayrollReimbursement
{
    public int CompanyId { get; set; }

    public int PayrollReimbursementId { get; set; }

    public int PayrollId { get; set; }

    public int ReimbursementId { get; set; }

    public double ReimbursementAmount { get; set; }

    public double ReimbursedAmount { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Payroll Payroll { get; set; } = null!;

    public virtual Reimbursement Reimbursement { get; set; } = null!;
}
