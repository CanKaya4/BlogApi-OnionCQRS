using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Tags.Commands.CreateTag
{
    public class CreateTagCommandValidator : AbstractValidator<CreateTagCommandRequest>
    {
        public CreateTagCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithName("Etiket İsmi");
        }
    }
}
