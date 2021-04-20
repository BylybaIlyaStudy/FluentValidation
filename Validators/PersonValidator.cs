using FluentValidation;
using WebApplication1.People;

namespace WebApplication1.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Age).NotEmpty().LessThan(200).WithMessage("Age error");
            RuleFor(x => x.Name).NotEmpty().MaximumLength(10).WithMessage("Name error");

            RuleFor(x => x).SetInheritanceValidator(v =>
            {
                v.Add<Adult>(new AdultValidator());
                v.Add<Student>(new StudentValidator());
            });
        }
    }
}
