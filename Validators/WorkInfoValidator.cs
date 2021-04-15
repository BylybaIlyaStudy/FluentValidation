using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Information;

namespace WebApplication1.Validators
{
    public static class WorkInfoValidator
    {
        public static IRuleBuilderOptions<T, WorkInfo> WorkInfoValidate<T>(this IRuleBuilder<T, WorkInfo> ruleBuilder)
        {
            return ruleBuilder
                .Must(workInfo => workInfo.Name.Length > 0)
                .Must(workInfo => workInfo.Address.Length > 0)
                .Must(workInfo => workInfo.Website.Length > 0)
                .WithMessage("WorkInfo error");
        }
    }
}
