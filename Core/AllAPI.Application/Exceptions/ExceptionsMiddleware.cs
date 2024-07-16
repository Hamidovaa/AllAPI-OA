﻿using Microsoft.AspNetCore.Http;
using SendGrid.Helpers.Errors.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAPI.Application.Exceptions
{
    public class ExceptionsMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext httpcontext, RequestDelegate next)
        {
            try
            {
                await next(httpcontext);
            }
            catch (Exception ex)
            {
                 await HandleExceptionAsync(httpcontext, ex);
            }
        }
        private static Task HandleExceptionAsync(HttpContext httpcontext, Exception exception) 
        {
            var statusCode = GetStatusCode(exception);
            httpcontext.Response.ContentType = "application/json";
            httpcontext.Response.StatusCode = statusCode;

            List<string> errors = new()
            {
                $"Error Message:{ exception.Message}",
                $"Error Description: {exception.InnerException?.ToString()}"
            };

            return httpcontext.Response.WriteAsync(new ExceptionModel
            {
                Errors=errors,
                StatusCode=statusCode
            }.ToString());

        }

        private static int GetStatusCode(Exception exception) =>
            exception switch
            {
                BadRequestException => StatusCodes.Status400BadRequest,
                NotFoundException => StatusCodes.Status400BadRequest,
                ValidationException => StatusCodes.Status422UnprocessableEntity,
                _=> StatusCodes.Status500InternalServerError,
            };
    }
}
