using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Service.Configuration
{
    public class UnhandledExceptionFilter : ActionFilterAttribute, IExceptionFilter
    {        
        public void OnException(ExceptionContext context)
        {           
            context.Result = new BadRequestObjectResult(context.Exception.Message);
        }
    }
}