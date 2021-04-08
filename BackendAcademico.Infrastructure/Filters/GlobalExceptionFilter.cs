namespace BackendAcademico.Infrastructure.Filters
{
    using BackendAcademico.Core.Exceptions;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using System.Net;

    public class GlobalExceptionFilter : IExceptionFilter
    {
        void IExceptionFilter.OnException(ExceptionContext context)
        {
            if (context.Exception.GetType() == typeof(BussinesException))
            {
                var exception = (BussinesException)context.Exception;
                var validation = new
                {
                    Status = 400,
                    Title = "Bab Request",
                    Detail = exception.Message
                };

                var json = new
                {
                    errors = new[] { validation }
                };

                context.Result = new BadRequestObjectResult(json);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.ExceptionHandled = true;

            }
        }
    }
}
