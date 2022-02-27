using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class StudentMaster
    {
        public StudentMaster()
        {
            StudentAddresses = new HashSet<StudentAddress>();
            StudentClasses = new HashSet<StudentClass>();
            StudentSubjectDetails = new HashSet<StudentSubjectDetail>();
        }

        public int StudentId { get; set; }
        public int RollNum { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime Dob { get; set; }
        public string? LastName { get; set; }

        public virtual ICollection<StudentAddress> StudentAddresses { get; set; }
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
        public virtual ICollection<StudentSubjectDetail> StudentSubjectDetails { get; set; }
    }
}
