using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class StudentSubjectDetail
    {
        public int StudentSubjectId { get; set; }
        public int StudentId { get; set; }
        public int ClassSubjectId { get; set; }
        public decimal Percentage { get; set; }

        public virtual ClassSubject ClassSubject { get; set; } = null!;
        public virtual StudentMaster Student { get; set; } = null!;
    }
}
