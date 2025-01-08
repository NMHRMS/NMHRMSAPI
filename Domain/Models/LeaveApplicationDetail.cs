using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class LeaveApplicationDetail
{
    public int CompanyId { get; set; }

    public int ApplicationDetailId { get; set; }

    public int ApplicationId { get; set; }

    public DateOnly LeaveDate { get; set; }

    public string Duration { get; set; } = null!;

    public string Status { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
