using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class ProfilePrivilege
{
    public int CompanyId { get; set; }

    public int PrivilegeId { get; set; }

    public int ProfileId { get; set; }

    public int ModuleId { get; set; }

    public int ProgramId { get; set; }

    public bool IsAdd { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public bool IsView { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual SystemModule Module { get; set; } = null!;

    public virtual Profile Profile { get; set; } = null!;

    public virtual CompanyProgram Program { get; set; } = null!;
}
