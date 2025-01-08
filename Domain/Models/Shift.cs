using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Shift
{
    public int CompanyId { get; set; }

    public int ShiftId { get; set; }

    public int LocationId { get; set; }

    public string ShiftName { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public int NetWorkingHours { get; set; }

    public bool IsRotation { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<EmployeeProfile> EmployeeProfiles { get; set; } = new List<EmployeeProfile>();

    public virtual Location Location { get; set; } = null!;

    public virtual ICollection<RosterDetail> RosterDetails { get; set; } = new List<RosterDetail>();

    public virtual ICollection<ShiftDetail> ShiftDetails { get; set; } = new List<ShiftDetail>();
}
