using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class SubjectMaster
    {
        public int SubjectId { get; set; }
        public string Subject { get; set; } = null!;
        public string? IsActive { get; set; }
    }
}
