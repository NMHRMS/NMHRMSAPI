using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class PayrollDeduction
{
    public int CompanyId { get; set; }

    public int PayrollDeductionId { get; set; }

    public int PayrollId { get; set; }

    public int DeductionId { get; set; }

    public double DeductionAmount { get; set; }

    public double DeductAmount { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
