using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class SalaryDeduction
{
    public int CompanyId { get; set; }

    public int SalayDeductionId { get; set; }

    public int SalaryTemplateId { get; set; }

    public int DeductionId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
