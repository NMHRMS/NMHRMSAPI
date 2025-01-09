using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class LeaveType
{
    public int CompanyId { get; set; }

    public int LeaveTypeId { get; set; }

    public string LeaveType1 { get; set; } = null!;

    public string LeaveCode { get; set; } = null!;

    public string? LeaveCategory { get; set; }

    public string? Description { get; set; }

    public string LeavePeriod { get; set; } = null!;

    public int LeaveCount { get; set; }

    public bool IsProRate { get; set; }

    public bool IsReset { get; set; }

    public string ResetPeriod { get; set; } = null!;

    public string IsCarryForward { get; set; } = null!;

    public int? CarryForwardCount { get; set; }

    public string? IsEncash { get; set; }

    public int? EncashCount { get; set; }

    public bool IsAllowNegative { get; set; }

    public bool IsAllowPastDate { get; set; }

    public int? PastLimit { get; set; }

    public bool IsAllowFutureDate { get; set; }

    public int? FutureLimt { get; set; }

    public string ApplicableTo { get; set; } = null!;

    public bool IsPostpone { get; set; }

    public string? PostponeBy { get; set; }

    public int? PostponeTo { get; set; }

    public DateOnly EffectiveFrom { get; set; }

    public DateOnly? EffectiveTill { get; set; }

    public bool IsHalfDayAllowed { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<LeaveApplication> LeaveApplications { get; set; } = new List<LeaveApplication>();
}
