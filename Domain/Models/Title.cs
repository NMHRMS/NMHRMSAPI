using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Title
{
    public int CompanyId { get; set; }

    public int TitleId { get; set; }

    public string Title1 { get; set; } = null!;

    public string? ShortName { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreareLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
