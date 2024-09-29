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
        public CreateArticleCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(CreateArticleCommandRequest request, CancellationToken cancellationToken)
        {
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
