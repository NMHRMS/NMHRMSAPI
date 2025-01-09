using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class StatutorySlab
{
    public int CompanyId { get; set; }

    public int StatutorySlabId { get; set; }

    public int StatutoryId { get; set; }

    public string Name { get; set; } = null!;

    public string GenderApplicable { get; set; } = null!;

    public decimal StartRange { get; set; }

    public decimal EndRange { get; set; }

    public decimal MonthlyTaxAmount { get; set; }

    public decimal? ExceptionMonthAmount { get; set; }

    public int SequenceNo { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Statutory Statutory { get; set; } = null!;
}
