using BusinessManager.Interface;
using Microsoft.AspNetCore.Mvc;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassService _classService;
        public ClassController(IClassService classService)
        {
            _classService = classService;
        }
        public ActionResult List()
        {
            ClassModel classModel = new ClassModel();
            classModel.classList = _classService.GetAllClass();
            return View(classModel);
        }
    }
}
