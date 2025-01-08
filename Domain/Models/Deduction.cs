using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Deduction
{
    public int CompanyId { get; set; }

    public int DeductionId { get; set; }

    public int DeductionTypeId { get; set; }

    public string TaxType { get; set; } = null!;

    public int AssociateTaxId { get; set; }

    public string PaySlipName { get; set; } = null!;

    public string DeductionMethod { get; set; } = null!;

    public bool IsIncludeInCtc { get; set; }

    public bool IsProReta { get; set; }

    public bool IsRecurring { get; set; }

    public int PrintSequence { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
