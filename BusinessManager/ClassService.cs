using BusinessManager.Interface;
using BusinessObject;
using DataLayer;
using DataLayer.Interface;

namespace BusinessManager
{
    public class ClassService : IClassService
    {
        public List<ClassMaster> GetAllClass()
        {
            IClassDB classDB = new ClassDB();
           return classDB.GetAllClass();    
        }
    }
}