using Microsoft.AspNetCore.Mvc;
using UI.Web.Helpers;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var user = HttpContext.Session.GetObjectFromJson<UserModel>("CurrentUser");
            if (user == null)
            {
                TempData["ErrorAlertMessage"] = "Invalid user name or password";
                return RedirectToAction("Login", "Account");
            }


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
