using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class AnnouncementDetail
{
    public int CompanyId { get; set; }

    public int AnnouncementDetailId { get; set; }

    public int AnnouncementId { get; set; }

    public string RoleId { get; set; } = null!;

    public string DepartmentId { get; set; } = null!;

    public double LocationId { get; set; }

    public DateOnly EmployeeId { get; set; }

    public bool IsRead { get; set; }

    public bool IsAcknowledged { get; set; }

    public DateTime? EngagedAt { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreareLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
