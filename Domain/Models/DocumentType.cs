using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class DocumentType
{
    public int CompanyId { get; set; }

    public int DocumentTypeId { get; set; }

    public string DocumentType1 { get; set; } = null!;

    public string IsCompulsory { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreareLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<EmployeeDocument> EmployeeDocuments { get; set; } = new List<EmployeeDocument>();
}
