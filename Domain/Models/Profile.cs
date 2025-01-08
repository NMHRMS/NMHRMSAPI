using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Profile
{
    public int CompanyId { get; set; }

    public int ProfileId { get; set; }

    public string Profile1 { get; set; } = null!;

    public bool IsAdmin { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<ProfilePrivilege> ProfilePrivileges { get; set; } = new List<ProfilePrivilege>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
