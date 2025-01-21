using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class CompanyProgram
{
    public int CompanyId { get; set; }

    public int ProgramId { get; set; }

    public string ProgramName { get; set; } = null!;

    public int ModuleId { get; set; }

    public string SequenceNo { get; set; } = null!;

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual CompanyModule Module { get; set; } = null!;

    public virtual ICollection<Udfdatum> Udfdata { get; set; } = new List<Udfdatum>();

    public virtual ICollection<Udf> Udfs { get; set; } = new List<Udf>();
}
