using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Tickit
{
    public int CompanyId { get; set; }

    public int TickitTypeId { get; set; }

    public int TickitId { get; set; }

    public int TicketNo { get; set; }

    public DateOnly TickitDate { get; set; }

    public int EmployeeId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateOnly PurchaseDate { get; set; }

    public int PriorityLevel { get; set; }

    public string Status { get; set; } = null!;

    public int AssignedToUserId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
