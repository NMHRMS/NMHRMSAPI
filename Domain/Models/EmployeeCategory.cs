using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class EmployeeCategory
{
    public int CompanyId { get; set; }

    public int CategoryId { get; set; }

    public string Category { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<EmployeeProfile> EmployeeProfiles { get; set; } = new List<EmployeeProfile>();
}
