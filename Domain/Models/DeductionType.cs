using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class DeductionType
{
    public int CompanyId { get; set; }

    public int DeductionTypeId { get; set; }

    public string DeductionType1 { get; set; } = null!;

    public string TaxType { get; set; } = null!;

    public string DeductionMethod { get; set; } = null!;

    public bool IsIncludeInCtc { get; set; }

    public bool IsProReta { get; set; }

    public bool IsRecurring { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<Deduction> Deductions { get; set; } = new List<Deduction>();
}
