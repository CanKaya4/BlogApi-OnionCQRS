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

namespace BlogApi.Application.Features.Articles.Queries.GetArticleWithPagination
{
    public class GetArticleWithPaginationHandler : BaseHandler, IRequestHandler<GetArticleWithPaginationRequest, GetArticleWithPaginationResponse>
    {
        public GetArticleWithPaginationHandler(ICustomMapper mapper,IUnitOfWork unitOfWork,IHttpContextAccessor httpContextAccessor) : base(mapper,unitOfWork,httpContextAccessor)
        {
            
        }

        public async Task<GetArticleWithPaginationResponse> Handle(GetArticleWithPaginationRequest request, CancellationToken cancellationToken)
        {
            // Veri sorgusunu başlat
            var articles = await _unitOfWork.GetReadRepository<Article>().GetAllAsync(
                include: x => x.Include(x => x.Tag)
                               .Include(x => x.ArticleCategories)
                               .ThenInclude(ac => ac.Category)
            );

            // Arama kelimesine göre filtreleme
            if (!string.IsNullOrWhiteSpace(request.SearchKeyword))
            {
                articles =  articles.Where(x => x.Title.Contains(request.SearchKeyword) || x.Content.Contains(request.SearchKeyword)).ToList();
            }

            // Kategoriye göre filtreleme
            if (request.CategoryId.HasValue)
            {
                articles = articles.Where(x => x.ArticleCategories.Any(ac => ac.CategoryId == request.CategoryId)).ToList();
            }

            // Toplam makale sayısını al
            int totalCount = articles.Count;

            // Sayfalama işlemini uygula
            var pagedArticles = articles
                 .Skip((request.PageNumber - 1) * request.PageSize)
                 .Take(request.PageSize)
                 .ToList();

            // Response hazırlama
            var response = new GetArticleWithPaginationResponse
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                TotalCount = totalCount,
                Articles = pagedArticles.Select(article => new GetArticleWithPaginationResponse.ArticleDetail
                {
                    Id = article.Id,
                    Title = article.Title,
                    Content = article.Content,
                    Keyword = article.Keyword,
                    Slug = article.Slug,
                    Description = article.Description, 
                    CreatedDate = article.CreatedDate,
                    IsDeleted = article.IsDeleted,
                    Tag = _mapper.Map<TagDto>(article.Tag),
                    CategoryNames = article.ArticleCategories.Select(ac => ac.Category.CategoryName).ToList()
                }).ToList()
            };

            return response;
        }
    }
}
