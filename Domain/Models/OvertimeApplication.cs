using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class OvertimeApplication
{
    public int CompanyId { get; set; }

    public int YearId { get; set; }

    public int MonthId { get; set; }

    public int ApplicationId { get; set; }

    public string ApplicationNo { get; set; } = null!;

    public DateOnly ApplicationDate { get; set; }

    public int EmployeeId { get; set; }

    public double StartTime { get; set; }

    public double EndTime { get; set; }

    public double? Duration { get; set; }

    public string Reason { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int? ApprovedById { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
