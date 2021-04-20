using Mapster;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.People;
using WebApplication1.Validators;

namespace WebApplication1.Controllers
{
    [Controller]
    public class PersonController : Controller
    {
        [HttpPost]
        public ActionResult Post(Person person)
        {
            return Ok();
        }
    }
}
