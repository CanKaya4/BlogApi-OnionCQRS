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

namespace BlogApi.Application.Features.Categories.Command.UpdateCategory
{
    public class UpdateCategoryCommandHandler : BaseHandler, IRequestHandler<UpdateCategoryCommandRequest,Unit>
    {
        public UpdateCategoryCommandHandler(ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<Unit> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            Category? category = await _unitOfWork.GetReadRepository<Category>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            if(category != null)
            {
                var map = _mapper.Map<Category, UpdateCategoryCommandRequest>(request);

                var articleCategory = await _unitOfWork.GetReadRepository<ArticleCategory>().GetAllAsync(x => x.CategoryId == category.Id);
                
                if(articleCategory.Count > 0 )
                {
                    await _unitOfWork.GetWriteRepository<ArticleCategory>().HardDeleteRangeAsync(articleCategory);

                    foreach(var item in request.ArticleIds)
                    {
                        await _unitOfWork.GetWriteRepository<ArticleCategory>().AddAsync(new()
                        {
                            CategoryId = category.Id,
                            ArticleId = item
                        });
                    }
                    await _unitOfWork.GetWriteRepository<Category>().UpdateAsync(map);
                    await _unitOfWork.SaveAsync();
                }
            }
            return Unit.Value;
        }
    }
}
