using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class WeeklyOffTemplate
{
    public int CompanyId { get; set; }

    public int YearId { get; set; }

    public int WeeklyOffTemplateId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreareLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<EmployeeProfile> EmployeeProfiles { get; set; } = new List<EmployeeProfile>();

    public virtual ICollection<WeeklyOffTemplateDay> WeeklyOffTemplateDays { get; set; } = new List<WeeklyOffTemplateDay>();

    public virtual Year Year { get; set; } = null!;
}
