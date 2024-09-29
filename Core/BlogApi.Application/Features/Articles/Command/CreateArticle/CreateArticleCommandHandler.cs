﻿using BlogApi.Application.Features.Articles.Rules;
using BlogApi.Application.Interfaces.UnitOfWorks;
using BlogApi.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Command.CreateArticle
{
    public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommandRequest, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ArticleRules _articleRules;
        public CreateArticleCommandHandler(IUnitOfWork unitOfWork, ArticleRules articleRules)
        {
            _unitOfWork = unitOfWork;
            _articleRules = articleRules;
        }
        public async Task<Unit> Handle(CreateArticleCommandRequest request, CancellationToken cancellationToken)
        {

            IList<Article> articles = await _unitOfWork.GetReadRepository<Article>().GetAllAsync();

            await _articleRules.ArticleTitleMustBeNotSame(articles, request.Title);
           
            Article article = new(request.Title,request.Content,request.TagId,request.Keyword,request.Description);
          

            await _unitOfWork.GetWriteRepository<Article>().AddAsync(article);
            if(await _unitOfWork.SaveAsync() > 0)
            {
                foreach(int item in request.CategoryIds)
                {
                    await _unitOfWork.GetWriteRepository<ArticleCategory>().AddAsync(new()
                    {
                        ArticleId = article.Id,
                        CategoryId = item
                    });
                }
                await _unitOfWork.SaveAsync();
            }
            return Unit.Value;
        }
    }
}
