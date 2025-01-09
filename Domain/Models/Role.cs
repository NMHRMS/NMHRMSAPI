using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Role
{
    public int CompanyId { get; set; }

    public int RoleId { get; set; }

    public string Role1 { get; set; } = null!;

    public int? ParentRoleId { get; set; }

    public bool IsCeo { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreareLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<AnnouncementDetail> AnnouncementDetails { get; set; } = new List<AnnouncementDetail>();

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<EmployeeProfile> EmployeeProfiles { get; set; } = new List<EmployeeProfile>();
}
