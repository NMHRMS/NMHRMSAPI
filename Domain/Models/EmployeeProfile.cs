using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class EmployeeProfile
{
    public int CompanyId { get; set; }

    public int EmployeeProfileId { get; set; }

    public int EmployeeId { get; set; }

    public string CardId { get; set; } = null!;

    public int DesignationId { get; set; }

    public int CategoryId { get; set; }

    public int GradeId { get; set; }

    public int ContractTypeId { get; set; }

    public int LocationId { get; set; }

    public DateOnly JoinDate { get; set; }

    public int HolidayTemplateId { get; set; }

    public int WeeklyOffTypeId { get; set; }

    public int ShiftId { get; set; }

    public int AttendancdModeId { get; set; }

    public int RoleId { get; set; }

    public int WeeklyOffTemplateId { get; set; }

    public bool IsPfeligible { get; set; }

    public string? Pfnumber { get; set; }

    public DateOnly? PfjoinDate { get; set; }

    public bool IsEsieligible { get; set; }

    public string? Esinumber { get; set; }

    public bool IsPteligible { get; set; }

    public bool IsLwfeligible { get; set; }

    public bool IsEpseligible { get; set; }

    public DateOnly? Epsjoining { get; set; }

    public DateOnly? Epsexit { get; set; }

    public bool IsHpseligible { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreareLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual AttendanceMode AttendancdMode { get; set; } = null!;

    public virtual EmployeeCategory Category { get; set; } = null!;

    public virtual Company Company { get; set; } = null!;

    public virtual ContractType ContractType { get; set; } = null!;

    public virtual Designation Designation { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual Grade Grade { get; set; } = null!;

    public virtual HolidayTemplate HolidayTemplate { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;

    public virtual Shift Shift { get; set; } = null!;

    public virtual WeeklyOffTemplate WeeklyOffTemplate { get; set; } = null!;
}
