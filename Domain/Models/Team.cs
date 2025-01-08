using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Team
{
    public int CompanyId { get; set; }

    public int TeamId { get; set; }

    public string Title { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
