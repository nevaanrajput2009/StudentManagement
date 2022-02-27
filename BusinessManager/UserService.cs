using BusinessManager.Interface;
using BusinessObject;
using DataLayer;
using DataLayer.Interface;

namespace BusinessManager
{
    public class UserService: IUserService
    {

        public UserMaster GetUserByUserNameAndPassword(string userName, string password)
        {
            IUserDB userDB = new UserDB();
           return userDB.GetUserByUserNameAndPassword(userName, password);    
        }
    }
}