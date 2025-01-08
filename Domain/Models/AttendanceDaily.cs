using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class AttendanceDaily
{
    public int CompanyId { get; set; }

    public int AttendancdDailyId { get; set; }

    public int AttendancdId { get; set; }

    public DateOnly WorkingDay { get; set; }

    public DateTime? InTime { get; set; }

    public DateTime? OutTime { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Attendance Attendancd { get; set; } = null!;

    public virtual Company Company { get; set; } = null!;
}
