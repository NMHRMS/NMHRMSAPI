using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class AssetType
{
    public int CompanyId { get; set; }

    public int AssetTypeId { get; set; }

    public string AssetType1 { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual Company Company { get; set; } = null!;
}
