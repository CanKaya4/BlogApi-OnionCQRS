using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Tags.Commands.UpdateTag
{
    public class UpdateTagCommandValidator : AbstractValidator<UpdateTagCommandRequest>
    {
        public UpdateTagCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
            RuleFor(x=>x.Name).NotEmpty().WithName("Etiket İsmi");
        }
    }
}
