using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class SystemProgram
{
    public int ProgramId { get; set; }

    public string ProgramName { get; set; } = null!;

    public int ModuleId { get; set; }

    public string SequenceNo { get; set; } = null!;

    public bool IsActive { get; set; }

    public int CreareLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual SystemModule Module { get; set; } = null!;

    public virtual ICollection<ProfilePrivilege> ProfilePrivileges { get; set; } = new List<ProfilePrivilege>();
}
