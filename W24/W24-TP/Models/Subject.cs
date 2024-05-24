using System;
using System.Collections.Generic;

namespace W24_TP.Models;

public partial class Subject
{
    public int Id { get; set; }

    public int FkCategory { get; set; }

    public string? FkUser { get; set; }

    public string Title { get; set; } = null!;

    public string Body { get; set; } = null!;

    public DateTime Date { get; set; }

    public int View { get; set; }

    public bool Active { get; set; }

    public virtual Category? FkCategoryNavigation { get; set; }

    public virtual AspNetUser? FkUserNavigation { get; set; }

    public virtual ICollection<Reply> Replies { get; set; } = new List<Reply>();
}
