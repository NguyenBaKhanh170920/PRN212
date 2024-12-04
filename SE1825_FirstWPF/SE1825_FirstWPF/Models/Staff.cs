using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1825_FirstWPF.Models
{
    internal class Staff
    {
        
            public int StaffId { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
            public int Role { get; set; } // 1: Admin, 0: Normal Staff

    }
}
