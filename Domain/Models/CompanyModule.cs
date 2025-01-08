using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class CompanyModule
{
    public int ModuleId { get; set; }

    public string ModuleName { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<SystemProgram> SystemPrograms { get; set; } = new List<SystemProgram>();
}
