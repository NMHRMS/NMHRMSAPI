using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class LeaveBalance
{
    public int CompanyId { get; set; }

    public int BalanceId { get; set; }

    public int YearId { get; set; }

    public int EmployeeId { get; set; }

    public int LeaveTypeId { get; set; }

    public double? Opening { get; set; }

    public double? Booked { get; set; }

    public double? Available { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
