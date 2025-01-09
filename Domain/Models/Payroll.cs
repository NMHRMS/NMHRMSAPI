using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Payroll
{
    public int CompanyId { get; set; }

    public int PayrollId { get; set; }

    public int YearId { get; set; }

    public int MonthId { get; set; }

    public int EmployeeId { get; set; }

    public int WorkingDays { get; set; }

    public int PresentDays { get; set; }

    public int SalaryDays { get; set; }

    public double GrossEarnings { get; set; }

    public double GrossDeductions { get; set; }

    public double NetAmount { get; set; }

    public string Status { get; set; } = null!;

    public string? PaymentMode { get; set; }

    public string? PaymentReference { get; set; }

    public DateOnly? PaidDate { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual Month Month { get; set; } = null!;

    public virtual ICollection<PayrollDeduction> PayrollDeductions { get; set; } = new List<PayrollDeduction>();

    public virtual ICollection<PayrollEarning> PayrollEarnings { get; set; } = new List<PayrollEarning>();

    public virtual ICollection<PayrollReimbursement> PayrollReimbursements { get; set; } = new List<PayrollReimbursement>();

    public virtual Year Year { get; set; } = null!;
}
