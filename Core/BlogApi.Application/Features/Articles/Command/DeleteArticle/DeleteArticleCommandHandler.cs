using BlogApi.Application.Interfaces.UnitOfWorks;
using BlogApi.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Command.DeleteArticle
{
    public class DeleteArticleCommandHandler : IRequestHandler<DeleteArticleCommandRequest, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteArticleCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
