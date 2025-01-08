using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class City
{
    public int CompanyId { get; set; }

    public int CityId { get; set; }

    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public int StateId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual State State { get; set; } = null!;
}
