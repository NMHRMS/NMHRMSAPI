using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class OvertimePolicy
{
    public int CompanyId { get; set; }

    public int PolicyId { get; set; }

    public int CategoryId { get; set; }

    public double OvertimeRate { get; set; }

    public double MaxHoursPerDay { get; set; }

    public double MaxHoursPerWeek { get; set; }

    public DateOnly EffectiveFrom { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
