using Microsoft.AspNetCore.Http;
using SendGrid.Helpers.Errors.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Exceptions
{
    public class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext httpContext, RequestDelegate next)
        {
            try
            {
                await next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }

        }
        private static Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        {
            var statusCode = GetStatusCode(ex);
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = statusCode;

            List<string> errors = new()
            {
               $"Hata Mesajı :  {ex.Message}" ,
               $"Hata Açıklaması :  {ex.InnerException?.ToString()}" 
            };

            return httpContext.Response.WriteAsync(new ExceptionModel()
            {
                Errors = errors,
                StatusCode = statusCode,
            }.ToString());
        }
        private static int GetStatusCode(Exception ex)=>
            ex switch
            {
                BadRequestException => StatusCodes.Status400BadRequest,
                NotFoundException => StatusCodes.Status400BadRequest,
                ValidationException => StatusCodes.Status422UnprocessableEntity,
                _ =>  StatusCodes.Status500InternalServerError
            };
    }
}
