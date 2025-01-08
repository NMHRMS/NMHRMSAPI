using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Notification
{
    public int CompanyId { get; set; }

    public int NotificationId { get; set; }

    public int TaskId { get; set; }

    public int EmployeeId { get; set; }

    public string NotificationType { get; set; } = null!;

    public DateTime SentAt { get; set; }

    public bool IsRead { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
