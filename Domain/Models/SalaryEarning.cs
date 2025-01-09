using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class SalaryEarning
{
    public int CompanyId { get; set; }

    public int SalaryEarningId { get; set; }

    public int SalaryTemplateId { get; set; }

    public int EarningId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Earning Earning { get; set; } = null!;
}
