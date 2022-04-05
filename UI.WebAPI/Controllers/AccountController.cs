using BusinessManager.Interface;
using Microsoft.AspNetCore.Mvc;
using UI.WebAPI.Model;

namespace UI.WebAPI.Controllers
{
    [ApiController]
    [Route("account")]
    public class AccountController : ControllerBase
    {
        IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("login/{userName}/{password}")]
        public bool Login(string userName, string password)
        {
          var userInfo =  _userService.GetUserByUserNameAndPassword(userName, password);   
            if(userInfo == null)
            {
                return false;
            }
            
            return true;
        }


        [HttpPost("login")]
        public bool Login(LoginModel accountModel)
        {
            var userInfo = _userService.GetUserByUserNameAndPassword(accountModel.UserName, accountModel.Password);
            if (userInfo == null)
            {
                return false;
            }

            return true;
        }
    }
}