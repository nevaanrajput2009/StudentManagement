using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class ClassSubject
    {
        public ClassSubject()
        {
            StudentSubjectDetails = new HashSet<StudentSubjectDetail>();
        }

        public int ClassSubjectId { get; set; }
        public int? ClassId { get; set; }
        public int? SubjectId { get; set; }

        public virtual ICollection<StudentSubjectDetail> StudentSubjectDetails { get; set; }
    }
}
