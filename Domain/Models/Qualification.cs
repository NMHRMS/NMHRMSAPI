using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Qualification
{
    public int CompanyId { get; set; }

    public int QualificationId { get; set; }

    public string Qualification1 { get; set; } = null!;

    public string? ShortName { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<EmployeeQualification> EmployeeQualifications { get; set; } = new List<EmployeeQualification>();
}
