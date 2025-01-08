using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Department
{
    public int? CompanyId { get; set; }

    public int DepartmentId { get; set; }

    public string Department1 { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public int SequenceNo { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company? Company { get; set; }
}
