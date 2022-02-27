using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class StaffKindMaster
    {
        public int StaffKindId { get; set; }
        public string Name { get; set; } = null!;
        public string? IsActive { get; set; }
    }
}
