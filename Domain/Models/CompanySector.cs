using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class CompanySector
{
    public int CompanySectorId { get; set; }

    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();
}
