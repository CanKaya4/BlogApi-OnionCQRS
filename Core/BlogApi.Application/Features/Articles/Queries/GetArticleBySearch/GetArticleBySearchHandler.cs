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

namespace BlogApi.Application.Features.Articles.Queries.GetArticleBySearch
{
    public class GetArticleBySearchHandler : BaseHandler, IRequestHandler<GetArticleBySearchRequest, GetArticleBySearchResponse>
    {
        public GetArticleBySearchHandler(ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<GetArticleBySearchResponse> Handle(GetArticleBySearchRequest request, CancellationToken cancellationToken)
        {
            // Makaleleri sorgulama (tag ve kategori bilgilerini dahil et)
            var articles = await _unitOfWork.GetReadRepository<Article>().GetAllAsync(
                include: x => x.Include(x => x.Tag)
                               .Include(x => x.ArticleCategories)
                               .ThenInclude(ac => ac.Category)
            );

            // Arama kelimesine göre filtreleme (Başlık veya içerikte arama)
            if (!string.IsNullOrWhiteSpace(request.SearchTerm))
            {
                var searchTerm = request.SearchTerm.ToLowerInvariant(); // Gelen searchTerm değerini küçük harfe çevir
                articles = articles.Where(x => x.Title.ToLowerInvariant().Contains(searchTerm)
                                             || x.Content.ToLowerInvariant().Contains(searchTerm)).ToList();
            }

            // Yanıtın toplam makale sayısını hesapla
            int totalCount = articles.Count;

            // Yanıt oluşturma
            var response = new GetArticleBySearchResponse
            {
                TotalCount = totalCount,
                Articles = articles.Select(article => new GetArticleBySearchResponse.ArticleDetail
                {
                    Id = article.Id,
                    Title = article.Title,
                    Content = article.Content,
                    CreatedDate = article.CreatedDate,
                    Keyword = article.Keyword,
                    Description = article.Description,
                    Slug = article.Slug,
                    IsDeleted = article.IsDeleted,
                    Tag = _mapper.Map<TagDto>(article.Tag),
                    CategoryNames = article.ArticleCategories.Select(ac => ac.Category.CategoryName).ToList()
                }).ToList()
            };

            return response;
        }
    }
}
