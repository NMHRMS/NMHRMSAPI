using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class RosterDetail
{
    public int CompanyId { get; set; }

    public int RosterDetailId { get; set; }

    public int RosterId { get; set; }

    public DateTime Day { get; set; }

    public int EmployeeId { get; set; }

    public int ShiftId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string Status { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual Shift Shift { get; set; } = null!;
}
