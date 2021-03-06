using FluentValidation;
using WebApplication1.People;

namespace WebApplication1.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.AverageScore).AverageScoreMustThanOneAndGreaterFive();
            RuleFor(x => x.Course).GreaterThan(0).LessThan(7).WithMessage("Course error");
        }
    }
}
