using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Categories.Command.CreateCategory
{
    public class CreateCategoryCommmandValidator : AbstractValidator<CreateCategoryCommmandRequest>
    {
        public CreateCategoryCommmandValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithName("Kategori İsmi");
         
        }
    }
}
