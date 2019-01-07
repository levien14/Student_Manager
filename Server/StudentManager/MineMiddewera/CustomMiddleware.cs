using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace StudentManager.MineMiddewera
{
    public static class RequestTokenHeader
    {
        public static IApplicationBuilder checkToken(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddleware>();
        }
    }
    public class CustomMiddleware
    {

        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        // IMyScopedService is injected into Invoke
        public async Task Invoke(HttpContext context)
        {
            bool IsValid = false;
            if (context.Request.Headers.ContainsKey("Authorization"))
            {
                var basicToken = context.Request.Headers["Authorization"].ToString();
                basicToken = basicToken.Replace("Basic ", "");
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage message = httpClient.GetAsync("https://localhost:44310/api/student/checkToken?tokenKey=" + basicToken).Result;
                if (message.StatusCode == HttpStatusCode.OK)
                {
                    IsValid = true;
                }
                
            }
            if (IsValid == true)
            {
                context.Response.StatusCode = 200;
                await _next(context);
            }
            else
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Forbidden");
            }
        }
    }
}
