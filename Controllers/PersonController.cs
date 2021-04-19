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
        public ActionResult Post([FromBody] PersonDTO personDTO)
        {
            Person person = personDTO.Adapt<Person>();

            var validator = new PersonValidator();
            var results = validator.Validate(person);

            if (results.IsValid)
            {
                return Ok();
            }

            return StatusCode(400);
        }
    }
}
