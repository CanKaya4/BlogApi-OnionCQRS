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

namespace BlogApi.Application.Features.Articles.Command.UpdateArticle
{
    public class UpdateArticleCommandHandler : BaseHandler,IRequestHandler<UpdateArticleCommandRequest, Unit>
    {
        public UpdateArticleCommandHandler(ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }
        public async Task<Unit> Handle(UpdateArticleCommandRequest request, CancellationToken cancellationToken)
        { 
            var article = await _unitOfWork.GetReadRepository<Article>().GetAsync(x=>x.Id == request.Id && !x.IsDeleted);
            if (article != null)
            {
                var map = _mapper.Map<Article, UpdateArticleCommandRequest>(request);

                var articleCategory = await _unitOfWork.GetReadRepository<ArticleCategory>().GetAllAsync(x => x.ArticleId == article.Id);

                if(articleCategory != null)
                {
                    await _unitOfWork.GetWriteRepository<ArticleCategory>().HardDeleteRangeAsync(articleCategory);

                    foreach(var item in request.CategoryIds)
                    {
                        await _unitOfWork.GetWriteRepository<ArticleCategory>().AddAsync(new()
                        {
                            CategoryId = item,
                            ArticleId = article.Id
                        });
                    }

                    await _unitOfWork.GetWriteRepository<Article>().UpdateAsync(map);
                    await _unitOfWork.SaveAsync();
                }
            }
            return Unit.Value;
        }
    }
}
