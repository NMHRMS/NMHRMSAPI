using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class AnnouncementDetail
{
    public int CompanyId { get; set; }

    public int AnnouncementDetailId { get; set; }

    public int AnnouncementId { get; set; }

    public int RoleId { get; set; }

    public int DepartmentId { get; set; }

    public int LocationId { get; set; }

    public int EmployeeId { get; set; }

    public bool IsRead { get; set; }

    public bool IsAcknowledged { get; set; }

    public DateTime? EngagedAt { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreareLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Department Department { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
