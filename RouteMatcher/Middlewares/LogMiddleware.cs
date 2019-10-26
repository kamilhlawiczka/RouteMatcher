using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Serilog;

namespace RouteMatcher.WebApi.Middlewares
{
    public class LogMiddleware
    {
        private readonly RequestDelegate next;

        public LogMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var url = httpContext.Request.GetDisplayUrl();
            var method = httpContext.Request.Method;

            await this.next(httpContext); // calling next middleware
            var status = httpContext.Response.StatusCode;
            var message = $"{status} {method} {url}";
            if (status < 300)
            {
                Log.Information(message);
            }
            else if (status < 400)
            {
                Log.Warning(message);
            }
            else if (status < 500)
            {
                Log.Error(message);
            }
            else
            {
                Log.Fatal(message);
            }
        }
    }
}