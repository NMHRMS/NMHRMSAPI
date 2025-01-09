using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class ReimbursementType
{
    public int CompanyId { get; set; }

    public int ReimbursementTypeId { get; set; }

    public string ReimbursementType1 { get; set; } = null!;

    public bool IsIncludeFbp { get; set; }

    public string ReimbursementMethod { get; set; } = null!;

    public decimal ReimbursementAmount { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<Reimbursement> Reimbursements { get; set; } = new List<Reimbursement>();
}
