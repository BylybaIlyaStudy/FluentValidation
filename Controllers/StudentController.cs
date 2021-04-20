using Mapster;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.People;
using WebApplication1.Validators;

namespace WebApplication1.Controllers
{
    [Controller]
    public class StudentController : Controller
    {
        [HttpPost]
        public ActionResult Post(StudentDTO studentDTO)
        {
            Student student = studentDTO.Adapt<Student>();

            var validator = new StudentValidator();
            var results = validator.Validate(student);

            if (!results.IsValid)
            {
                StatusCode(400);
                return StatusCode(400);
            }

            return Ok();
        }
    }
}
