using System;
using System.Collections.Generic;

namespace SE1825_GROUP2_PROJECT.Models;

public partial class User
{
    public int Id { get; set; }

    public int Role { get; set; }

    public string? FullName { get; set; }

    public string? Password { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<BorrowRecord> BorrowRecords { get; set; } = new List<BorrowRecord>();
}
