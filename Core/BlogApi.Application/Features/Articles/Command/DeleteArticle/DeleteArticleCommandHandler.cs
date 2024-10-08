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

namespace BlogApi.Application.Features.Articles.Command.DeleteArticle
{
    public class DeleteArticleCommandHandler :BaseHandler, IRequestHandler<DeleteArticleCommandRequest, Unit>
    {
        public DeleteArticleCommandHandler(ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }
        public async Task<Unit> Handle(DeleteArticleCommandRequest request, CancellationToken cancellationToken)
        {
            var article = await _unitOfWork.GetReadRepository<Article>().GetAsync(x => x.Id == request.Id);

            if (article != null)
            {
                article.IsDeleted = true;

                await _unitOfWork.GetWriteRepository<Article>().UpdateAsync(article);
                await _unitOfWork.SaveAsync();
            }
            return Unit.Value;
        }
    }
}
