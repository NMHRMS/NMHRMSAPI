using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Year
{
    public int CompanyId { get; set; }

    public int YearId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string YearLabel { get; set; } = null!;

    public string IsOpen { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<HolidayTemplate> HolidayTemplates { get; set; } = new List<HolidayTemplate>();

    public virtual ICollection<Month> Months { get; set; } = new List<Month>();

    public virtual ICollection<Roster> Rosters { get; set; } = new List<Roster>();

    public virtual ICollection<WeeklyOffTemplate> WeeklyOffTemplates { get; set; } = new List<WeeklyOffTemplate>();
}
