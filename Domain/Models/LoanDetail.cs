using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class LoanDetail
{
    public int CompanyId { get; set; }

    public int YearId { get; set; }

    public int MonthId { get; set; }

    public int ApplicationId { get; set; }

    public int LoanDetailId { get; set; }

    public double InstallmentAmount { get; set; }

    public double BalanceAmount { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
