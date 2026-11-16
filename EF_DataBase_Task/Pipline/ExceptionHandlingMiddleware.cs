using DB_Context_Employee.Models;
using System.Runtime.InteropServices;

namespace EF_DataBase_Task.Middleware
{
    public class ExceptionHandlingMiddleware
    {

        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {

            try
            {
                await _next(context);
            }

            catch (Exception ex)
            {
                context.Response.StatusCode = 404;
                context.Response.ContentType = "application/json";
                var response_error = new ErrorResponse
                {
                    
                    Message = " The User Not Found ",
                    StatusCode = context.Response.StatusCode
                };

                await context.Response.WriteAsJsonAsync(response_error);
            }

            
        }

    }

    }

