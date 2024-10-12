using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Tags.Commands.DeleteTag
{
    public class DeleteTagCommandValidator : AbstractValidator<DeleteTagCommandRequest>
    {
        public DeleteTagCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
        }
    }
}
