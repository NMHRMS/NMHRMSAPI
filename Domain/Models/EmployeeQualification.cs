using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class EmployeeQualification
{
    public int CompanyId { get; set; }

    public int EmployeeQualificationId { get; set; }

    public int EmployeeId { get; set; }

    public int QualificationId { get; set; }

    public string Qualification { get; set; } = null!;

    public string? Specialization { get; set; }

    public string Institute { get; set; } = null!;

    public DateOnly CompletionDate { get; set; }

    public string Note { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual Qualification QualificationNavigation { get; set; } = null!;
}
