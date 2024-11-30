using BlogApi.Application.Bases;
using BlogApi.Application.Interfaces.AutoMapper;
using BlogApi.Application.Interfaces.UnitOfWorks;
using BlogApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using SendGrid.Helpers.Errors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Command.UpdateArticle
{
    public class UpdateArticleCommandHandler : BaseHandler,IRequestHandler<UpdateArticleCommandRequest, Unit>
    {
        private readonly ILogger<UpdateArticleCommandHandler> _logger;
        public UpdateArticleCommandHandler(ILogger<UpdateArticleCommandHandler> logger, ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            _logger = logger; // Logger enjekte edildi
        }
        public async Task<Unit> Handle(UpdateArticleCommandRequest request, CancellationToken cancellationToken)
        {
            // Başlangıç logu: Güncelleme işlemine başlandığı loglanıyor.
            _logger.LogInformation("Start updating article with ID: {ArticleId}", request.Id);

            try
            {
                // Makale verisini al
                Article? article = await _unitOfWork.GetReadRepository<Article>().GetAsync(x => x.Id == request.Id);

                if (article == null)
                {
                    // Eğer makale bulunamazsa, uyarı logu yazılır
                    _logger.LogWarning("Article not found with ID: {ArticleId}", request.Id);
                    throw new NotFoundException("Article not found");
                }

                var map = _mapper.Map<Article, UpdateArticleCommandRequest>(request);

                var articleCategory = await _unitOfWork.GetReadRepository<ArticleCategory>().GetAllAsync(x => x.ArticleId == article.Id);

                if (articleCategory != null)
                {
                    // Önceki kategorileri sil
                    await _unitOfWork.GetWriteRepository<ArticleCategory>().HardDeleteRangeAsync(articleCategory);

                    // Yeni kategorileri ekle
                    foreach (var item in request.CategoryIds)
                    {
                        await _unitOfWork.GetWriteRepository<ArticleCategory>().AddAsync(new()
                        {
                            CategoryId = item,
                            ArticleId = article.Id
                        });
                    }

                    // Makale güncelleniyor
                    await _unitOfWork.GetWriteRepository<Article>().UpdateAsync(map);
                    await _unitOfWork.SaveAsync();

                    // Başarı logu: Makale başarılı bir şekilde güncellendi
                    _logger.LogInformation("Article with ID: {ArticleId} updated successfully", request.Id);
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda log yazılır
                _logger.LogError(ex, "An error occurred while updating article with ID: {ArticleId}", request.Id);
                throw;  // Hata tekrar fırlatılabilir
            }

            return Unit.Value;
        }
    }
}
