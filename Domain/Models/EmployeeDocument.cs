using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class EmployeeDocument
{
    public int CompanyId { get; set; }

    public int EmployeeDocumentId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime SubmitDate { get; set; }

    public int DocumentTypeId { get; set; }

    public string Document { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string DocumentPath { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual DocumentType DocumentType { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
