using System;
using System.Collections.Generic;

namespace SE1825_GROUP2_PROJECT.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
