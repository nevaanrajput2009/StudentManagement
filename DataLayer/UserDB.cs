using BusinessObject;
using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserDB: IUserDB
    {
        public UserMaster GetUserByUserNameAndPassword(string userName, string password)
        {
            using (var context = new StudentManagementSystemContext())
            {

                return context.UserMasters.Where(x => x.UserName == userName && x.Password == password).FirstOrDefault();
            }
        }
    }
}
