using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class HolidayTemplateDay
{
    public int CompanyId { get; set; }

    public int HolidayTemplateId { get; set; }

    public int DaysId { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly HolidayDate { get; set; }

    public string Description { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual HolidayTemplate HolidayTemplate { get; set; } = null!;
}
