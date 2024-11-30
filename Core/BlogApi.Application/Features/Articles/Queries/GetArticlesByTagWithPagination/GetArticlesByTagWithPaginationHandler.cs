using BlogApi.Application.Bases;
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

namespace BlogApi.Application.Features.Articles.Queries.GetArticlesByTagWithPagination
{
    public class GetArticlesByTagWithPaginationHandler : BaseHandler, IRequestHandler<GetArticlesByTagWithPaginationRequest, GetArticlesByTagWithPaginationResponse>
    {
        public GetArticlesByTagWithPaginationHandler(ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
           : base(mapper, unitOfWork, httpContextAccessor)
        {
        }
        public async Task<GetArticlesByTagWithPaginationResponse> Handle(GetArticlesByTagWithPaginationRequest request, CancellationToken cancellationToken)
        {
            // Makaleleri çek
            var articles = await _unitOfWork.GetReadRepository<Article>().GetAllAsync(
                include: x => x.Include(x => x.Tag)
                               .Include(x => x.ArticleCategories)
                               .ThenInclude(ac => ac.Category)
            );

            // Tag'e göre filtreleme
            if (request.TagId.HasValue)
            {
                articles = articles.Where(x => x.TagId == request.TagId).ToList();
            }

            // Toplam makale sayısını al
            int totalCount = articles.Count;

            // Sayfalama işlemini uygula
            var pagedArticles = articles
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToList();

            // Response hazırlama
            var response = new GetArticlesByTagWithPaginationResponse
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                TotalCount = totalCount,
                Articles = pagedArticles.Select(article => new GetArticlesByTagWithPaginationResponse.ArticleDetail
                {
                    Id = article.Id,
                    Title = article.Title,
                    Content = article.Content,
                    Keyword = article.Keyword,
                    Slug = article.Slug,
                    Description = article.Description,
                    CreatedDate = article.CreatedDate,
                    IsDeleted = article.IsDeleted,
                    TagName = article.Tag.Name, // İlgili Tag'in adı
                    CategoryNames = article.ArticleCategories.Select(ac => ac.Category.CategoryName).ToList()
                }).ToList()
            };

            return response;
        }
    }
}
