using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class WeeklyOffTemplateDay
{
    public int CompanyId { get; set; }

    public int WeeklyOffTemplateId { get; set; }

    public int DayId { get; set; }

    public string DayName { get; set; } = null!;

    public bool IsFristWeek { get; set; }

    public bool IsScondWeek { get; set; }

    public bool IsThirdWeek { get; set; }

    public bool IsFourthWeek { get; set; }

    public bool IsFifthWeek { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreareLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual WeeklyOffTemplate WeeklyOffTemplate { get; set; } = null!;
}
