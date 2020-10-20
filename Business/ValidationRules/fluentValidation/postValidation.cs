using Entities.conc;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.fluentValidation
{
   public class postValidation:AbstractValidator<Posts>
    {
        public postValidation()
        {
           
            RuleFor(x => x.ReadCount).GreaterThan(1);
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.CategoryId).NotNull();
            RuleFor(x => x.Description).MaximumLength(100);
            RuleFor(x => x.Text).MinimumLength(50);

        }
    }
}
