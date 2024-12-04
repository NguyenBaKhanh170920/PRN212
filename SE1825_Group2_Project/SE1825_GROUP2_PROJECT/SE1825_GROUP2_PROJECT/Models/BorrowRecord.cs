using System;
using System.Collections.Generic;

namespace SE1825_GROUP2_PROJECT.Models;

public partial class BorrowRecord
{
    public int Id { get; set; }

    public int BookId { get; set; }

    public int BorrowerId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public int Quantity { get; set; }

    public string Status { get; set; } = null!;

    public virtual Book Book { get; set; } = null!;

    public virtual User Borrower { get; set; } = null!;
}
