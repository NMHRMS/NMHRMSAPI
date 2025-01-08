using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Roster
{
    public int CompanyId { get; set; }

    public int RosterId { get; set; }

    public int YearId { get; set; }

    public int LocationId { get; set; }

    public string RosterPeriod { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Status { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual Year Year { get; set; } = null!;
}
