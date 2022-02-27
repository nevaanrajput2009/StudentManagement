using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class ClassMaster
    {
        public ClassMaster()
        {
            StudentClasses = new HashSet<StudentClass>();
        }

        public int ClassId { get; set; }
        public string ClassName { get; set; } = null!;
        public string? IsActive { get; set; }

        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
