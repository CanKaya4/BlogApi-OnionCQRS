using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Command.DeleteArticle
{
    public class DeleteArticleCommandValidator : AbstractValidator<DeleteArticleCommandRequest>
    {
        public DeleteArticleCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
        }
    }
}
