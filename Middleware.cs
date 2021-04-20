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
    public class Middleware
    {
        private readonly RequestDelegate _next;

        public Middleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string responseString = context.Request.QueryString.Value;
            var dict = HttpUtility.ParseQueryString(responseString);
            string json = JsonConvert.SerializeObject(dict.Cast<string>().ToDictionary(k => k, v => dict[v]));
            Person person = JsonConvert.DeserializeObject<Person>(json);

            var validator = new PersonValidator();
            var results = validator.Validate(person);

            if (!results.IsValid)
            {
                context.Response.StatusCode = 418;
            }

            context.Response.Headers.Add("Date", DateTime.Now.ToString());

            await _next.Invoke(context);
        }
    }
}
