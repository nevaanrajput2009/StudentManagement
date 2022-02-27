using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class UserMaster
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
