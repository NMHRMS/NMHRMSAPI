using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class TeamMember
{
    public int CompanyId { get; set; }

    public int MemberId { get; set; }

    public int TeamId { get; set; }

    public string EmployeeId { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
