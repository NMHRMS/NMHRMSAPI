using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Earning
{
    public int CompanyId { get; set; }

    public int EarningId { get; set; }

    public int EarningTypeId { get; set; }

    public string PaySlipName { get; set; } = null!;

    public string CalculationType { get; set; } = null!;

    public string PayType { get; set; } = null!;

    public bool IsAddInStructure { get; set; }

    public bool IsScheduled { get; set; }

    public bool IsTaxble { get; set; }

    public bool IsProReta { get; set; }

    public string Epfcontribution { get; set; } = null!;

    public bool IsEsicontribution { get; set; }

    public bool IsShowInPayslip { get; set; }

    public bool IsFbplimitOverride { get; set; }

    public bool IsFbpproofRequired { get; set; }

    public bool IsFbppayroll { get; set; }

    public bool IsExcludeOvertime { get; set; }

    public string TdsdeductMethod { get; set; } = null!;

    public bool IsIncludeInCtc { get; set; }

    public int PrintSequence { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
