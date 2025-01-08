using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class TaskAttachment
{
    public int CompanyId { get; set; }

    public int AttachmentId { get; set; }

    public string TaskId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string AttachmentPath { get; set; } = null!;

    public DateTime StatusDate { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }
}
