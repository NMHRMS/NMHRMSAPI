using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class HolidayTemplate
{
    public int CompanyId { get; set; }

    public int YearId { get; set; }

    public int HolidayTemplateId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<EmployeeProfile> EmployeeProfiles { get; set; } = new List<EmployeeProfile>();

    public virtual ICollection<HolidayTemplateDay> HolidayTemplateDays { get; set; } = new List<HolidayTemplateDay>();

    public virtual Year Year { get; set; } = null!;
}
