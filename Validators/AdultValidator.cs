using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.People;

namespace WebApplication1.Validators
{
    public class AdultValidator : AbstractValidator<Adult>
    {
        public AdultValidator()
        {
            RuleFor(x => x.Salary).NotEmpty().GreaterThan(0).WithMessage("Salary error");
            RuleFor(x => x.WorkInfo).WorkInfoValidate();
        }
    }
}
