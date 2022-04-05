using BusinessObject;
using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ClassDB: IClassDB
    {
        public List<ClassMaster> GetAllClass()
        {
            var classContext = new StudentManagementSystemContext();
            return classContext.ClassMasters.ToList();
        }
    }
}
