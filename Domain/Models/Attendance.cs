using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Attendance
{
    public int CompanyId { get; set; }

    public int AttendanceId { get; set; }

    public int YearId { get; set; }

    public int MonthId { get; set; }

    public int EmployeeId { get; set; }

    public int WorkingDays { get; set; }

    public int PresentDays { get; set; }

    public int NoWorkingDays { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<AttendanceDaily> AttendanceDailies { get; set; } = new List<AttendanceDaily>();

    public virtual Company Company { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual Month Month { get; set; } = null!;

    public virtual Year Year { get; set; } = null!;
}
