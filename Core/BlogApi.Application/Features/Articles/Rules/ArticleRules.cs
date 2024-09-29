using BlogApi.Application.Bases;
using BlogApi.Application.Features.Articles.Exceptions;
using BlogApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Rules
{
    public class ArticleRules : BaseRules
    {
        public Task ArticleTitleMustBeNotSame(IList<Article> articles, string requestTitle)
        {
            if(articles.Any(x=>x.Title == requestTitle))
            {
                throw new ArticleTitleMustNotBeSameException();
            }
            return Task.CompletedTask;
        }
    }
}
