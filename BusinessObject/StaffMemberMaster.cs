using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class StaffMemberMaster
    {
        public int StaffMemberId { get; set; }
        public string MemberName { get; set; } = null!;
        public string? LastName { get; set; }
        public string Gender { get; set; } = null!;
        public DateTime Dob { get; set; }
        public int? StaffKindId { get; set; }
        public int? ManagerId { get; set; }
    }
}
