using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class ContractType
{
    public int CompanyId { get; set; }

    public int ContractTypeId { get; set; }

    public string ContractType1 { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<EmployeeProfile> EmployeeProfiles { get; set; } = new List<EmployeeProfile>();
}
