using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class AssociateTaxis
{
    public int CompanyId { get; set; }

    public int AssociateTaxId { get; set; }

    public string TaxName { get; set; } = null!;

    public string TaxGroup { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<Deduction> Deductions { get; set; } = new List<Deduction>();
}
