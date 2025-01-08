using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class SalaryReimbursement
{
    public int CompanyId { get; set; }

    public int SalaryTemplateId { get; set; }

    public int SalaryReimbursementId { get; set; }

    public int ReimbursementId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
