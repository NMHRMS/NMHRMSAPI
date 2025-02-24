﻿using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class ExpenseType
{
    public int CompanyId { get; set; }

    public int ExpenseTypeId { get; set; }

    public string ExpenseType1 { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreareLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<AdvanceApplication> AdvanceApplications { get; set; } = new List<AdvanceApplication>();

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<ExpenseClaim> ExpenseClaims { get; set; } = new List<ExpenseClaim>();
}
