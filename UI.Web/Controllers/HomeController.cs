using Microsoft.AspNetCore.Mvc;
using UI.Web.Helpers;

namespace UI.Web.Controllers
{
  
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

        [Route("b/{id:bool}")]
        public IActionResult About(bool id)
        {
            return View();
        }

        [Route("b/{id:decimal}")]
        public IActionResult About(decimal id)
        {
            return View();
        }
    }
}
