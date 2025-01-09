using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Statutory
{
    public int CompanyId { get; set; }

    public int StatutoryId { get; set; }

    public string Name { get; set; } = null!;

    public string StatutoryNumber { get; set; } = null!;

    public string DeductionCycle { get; set; } = null!;

    public decimal EmployeeContributionRate { get; set; }

    public decimal EmployerContributionRate { get; set; }

    public bool IsIncludeInCtc { get; set; }

    public string? IsIncludeEmployerContriInCtc { get; set; }

    public string? IsIncludeAdminInCtc { get; set; }

    public bool IsOverridePfcontribution { get; set; }

    public bool IsLopappliedProRete { get; set; }

    public bool IsConsiderAllSalary { get; set; }

    public bool IsEligibleForAbry { get; set; }

    public string? IsSlabApplicable { get; set; }

    public bool IsAutoStop { get; set; }

    public string? IsDeductEndContribution { get; set; }

    public string? IsAutoStopForSalaryAbove { get; set; }

    public int? ApplicableStateId { get; set; }

    public int MonthId { get; set; }

    public string BonusPaymentFrequency { get; set; } = null!;

    public decimal BonusMonthlyPercent { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<StatutorySlab> StatutorySlabs { get; set; } = new List<StatutorySlab>();
}
