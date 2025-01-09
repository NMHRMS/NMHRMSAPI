using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class TickitType
{
    public int CompanyId { get; set; }

    public int TickitTypeId { get; set; }

    public string TickitType1 { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<Tickit> Tickits { get; set; } = new List<Tickit>();
}
