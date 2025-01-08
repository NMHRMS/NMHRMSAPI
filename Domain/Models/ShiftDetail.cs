using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class ShiftDetail
{
    public int CompanyId { get; set; }

    public int ShiftDetailId { get; set; }

    public int ShiftId { get; set; }

    public int StartTime { get; set; }

    public string StartTimeFormat { get; set; } = null!;

    public int EndTime { get; set; }

    public string EndTimeFormat { get; set; } = null!;

    public int BreakTime { get; set; }

    public bool IsBreakPaid { get; set; }

    public int ShiftDetailHours { get; set; }

    public int SequenceNo { get; set; }

    public bool RestApplicable { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Shift Shift { get; set; } = null!;
}
