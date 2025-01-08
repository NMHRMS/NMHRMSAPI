using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Asset
{
    public int CompanyId { get; set; }

    public int AssetTypeId { get; set; }

    public int AssetId { get; set; }

    public string AssetName { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public double PurchaseCost { get; set; }

    public DateOnly PurchaseDate { get; set; }

    public int LocationId { get; set; }

    public string Status { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
