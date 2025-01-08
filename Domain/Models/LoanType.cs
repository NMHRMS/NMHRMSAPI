using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class LoanType
{
    public int CompanyId { get; set; }

    public int LoanTypeId { get; set; }

    public string LoanType1 { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? PerquisiteRate { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
