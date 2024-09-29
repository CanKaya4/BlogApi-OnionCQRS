using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Command.CreateArticle
{
    public class CreateArticleCommandValidator : AbstractValidator<CreateArticleCommandRequest>
    {
        public CreateArticleCommandValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithName("Başlık");

            RuleFor(x => x.Content).NotEmpty().WithName("İçerik");

            RuleFor(x => x.TagId).GreaterThan(0).WithName("Etiket");

            RuleFor(x => x.Keyword).NotEmpty().WithName("Anahtar Kelime");

            RuleFor(x => x.Description).NotEmpty().WithName("Açıklama");

            RuleFor(x => x.CategoryIds).NotEmpty().Must(x => x.Any()).WithName("Kategoriler");

        }
    }
}
