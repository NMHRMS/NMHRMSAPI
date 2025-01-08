using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class State
{
    public int CompanyId { get; set; }

    public int StateId { get; set; }

    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public int? CountryId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual Company Company { get; set; } = null!;

    public virtual Country? Country { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
