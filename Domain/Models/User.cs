using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class User
{
    public int CompanyId { get; set; }

    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int ProfileId { get; set; }

    public string MobileNo { get; set; } = null!;

    public string EmailId { get; set; } = null!;

    public int? EmployeeId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Profile Profile { get; set; } = null!;
}
