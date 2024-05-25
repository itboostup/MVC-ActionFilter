using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilter.Filter
{
    public class CustomActionFilter : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            //Do Logic check before Action Executing
            Console.WriteLine("OnActionExecuting");
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //Do Logic checks After Action Executed
            Console.WriteLine("OnActionExecuted");

        }
    }
}
