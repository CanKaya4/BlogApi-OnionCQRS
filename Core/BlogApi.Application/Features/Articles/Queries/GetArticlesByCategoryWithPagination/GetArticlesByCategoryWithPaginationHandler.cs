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

namespace BlogApi.Application.Features.Articles.Queries.GetArticlesByCategoryWithPagination
{
    public class GetArticlesByCategoryWithPaginationHandler : BaseHandler, IRequestHandler<GetArticlesByCategoryWithPaginationRequest, GetArticlesByCategoryWithPaginationResponse>
    {
        public GetArticlesByCategoryWithPaginationHandler(ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
      : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<GetArticlesByCategoryWithPaginationResponse> Handle(GetArticlesByCategoryWithPaginationRequest request, CancellationToken cancellationToken)
        {
            // Makaleleri çek
            var articles = await _unitOfWork.GetReadRepository<Article>().GetAllAsync(
                include: x => x.Include(x => x.Tag)
                               .Include(x => x.ArticleCategories)
                               .ThenInclude(ac => ac.Category)
            );

            // Kategoriye göre filtreleme
            articles = articles.Where(x => x.ArticleCategories.Any(ac => ac.CategoryId == request.CategoryId)).ToList();

            // Toplam makale sayısını al
            int totalCount = articles.Count;

            // Sayfalama işlemini uygula
            var pagedArticles = articles
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToList();

            // Response hazırlama
            var response = new GetArticlesByCategoryWithPaginationResponse
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                TotalCount = totalCount,
                Articles = pagedArticles.Select(article => new GetArticlesByCategoryWithPaginationResponse.ArticleDetail
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
