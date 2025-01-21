using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Udfdatum
{
    public int CompanyId { get; set; }

    public int UdfdataId { get; set; }

    public int Udfid { get; set; }

    public string FieldName { get; set; } = null!;

    public int ProgramId { get; set; }

    public string DataType { get; set; } = null!;

    public string IsRequired { get; set; } = null!;

    public int EntityId { get; set; }

    public string? DataValue { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreareLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual CompanyProgram Program { get; set; } = null!;

    public virtual Udf Udf { get; set; } = null!;
}
