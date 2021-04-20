using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebApplication1.People;
using WebApplication1.Validators;

namespace WebApplication1
{
    public class MiddlewareDate
    {
        private readonly RequestDelegate _next;

        public MiddlewareDate(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.Headers.Add("Date", DateTime.Now.ToString());

            await _next.Invoke(context);
        }
    }
}
