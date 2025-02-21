﻿using System;
using System.Collections.Generic;

namespace ASPCoreAPICRUD.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string EmpName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
