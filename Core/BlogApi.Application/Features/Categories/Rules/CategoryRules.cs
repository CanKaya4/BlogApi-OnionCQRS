using BlogApi.Application.Bases;
using BlogApi.Application.Features.Categories.Exceptions;
using BlogApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Categories.Rules
{
    public class CategoryRules : BaseRules
    {
        public Task CategoryTitleMustBeNotSame(IList<Category> categories, string requestCategoryName)
        {
            if(categories.Any(x=>x.CategoryName == requestCategoryName))
            {
                throw new CategoryTitleMustNotBeSameException();
            }
            return Task.CompletedTask;
        }
    }
}
