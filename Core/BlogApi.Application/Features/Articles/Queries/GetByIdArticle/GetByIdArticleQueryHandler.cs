using BlogApi.Application.Bases;
using BlogApi.Application.DTOs;
using BlogApi.Application.Interfaces.AutoMapper;
using BlogApi.Application.Interfaces.UnitOfWorks;
using BlogApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Queries.GetByIdArticle
{
    public class GetByIdArticleQueryHandler :BaseHandler, IRequestHandler<GetByIdArticleQueryRequest, GetByIdArticleQueryResponse>
    {
        public GetByIdArticleQueryHandler(ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<GetByIdArticleQueryResponse> Handle(GetByIdArticleQueryRequest request, CancellationToken cancellationToken)
        {
            Article? article = await _unitOfWork.GetReadRepository<Article>().GetAsync(x=>x.Id == request.Id,include: x=>x.Include(x=>x.Tag).Include(b=>b.ArticleCategories).ThenInclude(ac=>ac.Category));

            var tag = _mapper.Map<TagDto, Tag>(new Tag());

            //var map = _mapper.Map<GetByIdArticleQueryResponse, Article>(article);

            //return map;

            var response = new GetByIdArticleQueryResponse
            {
                Id = article.Id,
                Title = article.Title,
                Content = article.Content,
                Keyword = article.Keyword,
                IsDeleted = article.IsDeleted,
                Tag = tag,
                CategoryNames = article.ArticleCategories.Select(ac=>ac.Category.CategoryName).ToList(),

            };

            return response;

            
        }
    }
}
