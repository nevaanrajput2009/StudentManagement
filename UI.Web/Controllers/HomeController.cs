using Microsoft.AspNetCore.Mvc;
using UI.Web.Helpers;

namespace UI.Web.Controllers
{
    [UserAuthorizationActionFilter]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
