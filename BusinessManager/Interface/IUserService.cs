using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Interface
{
    public interface IUserService
    {
        UserMaster GetUserByUserNameAndPassword(string userName, string password);
    }
}
