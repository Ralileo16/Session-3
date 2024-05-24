using System;
using System.Collections.Generic;

namespace W24_TP.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Img { get; set; }

    public bool Active { get; set; }

    public int Stars { get; set; }

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
