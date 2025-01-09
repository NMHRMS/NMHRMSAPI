using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Location
{
    public int CompanyId { get; set; }

    public int LocationId { get; set; }

    public string Location1 { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public int CountryId { get; set; }

    public string? Pincode { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<AnnouncementDetail> AnnouncementDetails { get; set; } = new List<AnnouncementDetail>();

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<EmployeeProfile> EmployeeProfiles { get; set; } = new List<EmployeeProfile>();

    public virtual ICollection<Roster> Rosters { get; set; } = new List<Roster>();

    public virtual ICollection<Shift> Shifts { get; set; } = new List<Shift>();
}
