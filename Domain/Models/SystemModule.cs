using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class SystemModule
{
    public int CompanyId { get; set; }

    public int ModuleId { get; set; }

    public string ModuleName { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public bool IsActive { get; set; }

    public int CreareLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<CompanyProgram> CompanyPrograms { get; set; } = new List<CompanyProgram>();

    public virtual ICollection<ProfilePrivilege> ProfilePrivileges { get; set; } = new List<ProfilePrivilege>();
}
