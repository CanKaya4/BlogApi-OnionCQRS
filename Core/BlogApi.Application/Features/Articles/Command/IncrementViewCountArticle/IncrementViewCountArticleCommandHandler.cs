using BlogApi.Application.Bases;
using BlogApi.Application.Interfaces.AutoMapper;
using BlogApi.Application.Interfaces.UnitOfWorks;
using BlogApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Command.IncrementViewCountArticle
{
    public class IncrementViewCountArticleCommandHandler :BaseHandler, IRequestHandler<IncrementViewCountArticleCommandRequest>
    {
        public IncrementViewCountArticleCommandHandler(ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task Handle(IncrementViewCountArticleCommandRequest request, CancellationToken cancellationToken)
        {
            var articleId = request.Id;
            var article = await _unitOfWork.GetReadRepository<Article>().GetAsync(x => x.Id == articleId);

            if(article == null)
            {
                throw new Exception("Makale Bulunamadı");
            }

            article.ReadCount++;

            await _unitOfWork.GetWriteRepository<Article>().UpdateAsync(article);
            await _unitOfWork.SaveAsync();

             
        }
    }
}
