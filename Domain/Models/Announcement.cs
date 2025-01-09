using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Announcement
{
    public int CompanyId { get; set; }

    public int AnnouncementId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string AnnouncmentTo { get; set; } = null!;

    public string? Roles { get; set; }

    public string? Departmets { get; set; }

    public string? Locations { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Priority { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreareLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;
}
