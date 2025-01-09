using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class TickitAttachment
{
    public int CompanyId { get; set; }

    public int AttachmentId { get; set; }

    public int TickitId { get; set; }

    public string Title { get; set; } = null!;

    public string AttachmentPath { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public int CreateLoginId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? UpdateLoginId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Tickit Tickit { get; set; } = null!;
}
