using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.People;

namespace WebApplication1.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Age).NotEmpty().LessThan(200).WithMessage("Age error");

            RuleFor(x => x).SetInheritanceValidator(v => {
                v.Add<Adult>(new AdultValidator());
                v.Add<Student>(new StudentValidator());
            });
        }
    }
}
