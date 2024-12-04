using System;
using System.Collections.Generic;

namespace SE1825_GROUP2_PROJECT.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Quantity { get; set; }

    public string? Publisher { get; set; }

    public int? Price { get; set; }

    public int CategoryId { get; set; }

    public virtual ICollection<BorrowRecord> BorrowRecords { get; set; } = new List<BorrowRecord>();

    public virtual Category Category { get; set; } = null!;
}
