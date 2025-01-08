using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class EmployeeBank
{
    public int CompanyId { get; set; }

    public int EmployeeBankId { get; set; }

    public int EmployeeId { get; set; }

    public string BankName { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public string Ifsccode { get; set; } = null!;

    public string? AccountName { get; set; }

    public string? Upiid { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
