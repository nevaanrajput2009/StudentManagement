using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public string? Designation { get; set; }
        public decimal? Salary { get; set; }
        public string? Gender { get; set; }
    }
}
