using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class StudentAddress
    {
        public int StudentAddressId { get; set; }
        public string? Address { get; set; }
        public decimal? MobileNumber { get; set; }
        public int? StudentId { get; set; }

        public virtual StudentMaster? Student { get; set; }
    }
}
