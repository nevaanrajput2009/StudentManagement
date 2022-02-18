using Microsoft.AspNetCore.Mvc;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            var model = new LoginModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            return View(model);
        }
    }
}
