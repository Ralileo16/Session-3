using System;
using System.Collections.Generic;

namespace W24_TP.Models;

public partial class Reply
{
    public int Id { get; set; }

    public int FkSubject { get; set; }

    public string? FkUser { get; set; }

    public string Body { get; set; } = null!;

    public DateTime Date { get; set; }

    public bool Active { get; set; }

    public virtual Subject? FkSubjectNavigation { get; set; }

    public virtual AspNetUser? FkUserNavigation { get; set; }
}
