using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Reimbursement
{
    public int CompanyId { get; set; }

    public int ReimbursementId { get; set; }

    public int ReimbursementTypeId { get; set; }

    public bool IsIncludeFbp { get; set; }

    public string ReimbursementType { get; set; } = null!;

    public decimal ReimbursementAmount { get; set; }

    public int PrintSequence { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
