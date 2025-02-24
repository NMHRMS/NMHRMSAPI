﻿using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class ExitType
{
    public int CompanyId { get; set; }

    public int ExitTypeId { get; set; }

    public string ExitType1 { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<ResignationApplication> ResignationApplications { get; set; } = new List<ResignationApplication>();
}
