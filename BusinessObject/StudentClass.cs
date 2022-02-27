using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class StudentClass
    {
        public int StudentClassId { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        public virtual ClassMaster Class { get; set; } = null!;
        public virtual StudentMaster Student { get; set; } = null!;
    }
}
