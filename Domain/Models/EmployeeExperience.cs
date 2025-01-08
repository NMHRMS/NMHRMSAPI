using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class EmployeeExperience
{
    public int CompanyId { get; set; }

    public int EmployeeExperienceId { get; set; }

    public int EmployeeId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

    public DateOnly FromDate { get; set; }

    public DateOnly ToDate { get; set; }

    public string? JobDescription { get; set; }

    public string IsRelevant { get; set; } = null!;

    public int Experience { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
