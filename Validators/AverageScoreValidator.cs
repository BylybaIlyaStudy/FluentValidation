using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Validators
{
    public static class AverageScoreValidator
    {
        public static IRuleBuilderOptions<T, double> AverageScoreMustThanOneAndGreaterFive<T>(this IRuleBuilder<T, double> ruleBuilder)
        {
            return ruleBuilder
                .Must(averageScore => (averageScore <= 5) && (averageScore >= 1))
                .WithMessage("The average score is impossible");
        }
    }
}
