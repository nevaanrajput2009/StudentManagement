using Microsoft.AspNetCore.Mvc.Filters;

namespace UI.Web.Helpers
{
    public class CustomActionFilter : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            //To do : before the action executes  
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //To do : after the action executes  
        }
    }
}
