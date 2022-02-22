using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using UI.Web.Models;

namespace UI.Web.Helpers
{
    public class UserAuthorizationActionFilter : Attribute, IActionFilter, IExceptionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            //To do : before the action executes      
            var user = context.HttpContext.Session.GetObjectFromJson<UserModel>("CurrentUser");
            if (user == null)
            {
                var controller = (Controller)context.Controller;
                context.Result = controller.RedirectToAction("login", "account");
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //To do : after the action executes  
        }

        public void OnException(ExceptionContext context)
        {
          
        }
    }
}
