using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GenericController.Managers
{
    public class AuthenticationAttribute : ActionFilterAttribute
    {
        public int Entity { get; set; }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var args = context.ActionArguments;

            //base.OnActionExecuting(context);
        }
    }
}
