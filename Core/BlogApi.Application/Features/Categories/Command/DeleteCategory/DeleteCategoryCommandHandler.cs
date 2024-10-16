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

namespace BlogApi.Application.Features.Categories.Command.DeleteCategory
{
    public class DeleteCategoryCommandHandler : BaseHandler, IRequestHandler<DeleteCategoryCommandRequest, Unit>
    {
        public DeleteCategoryCommandHandler(ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<Unit> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            Category? category = await _unitOfWork.GetReadRepository<Category>().GetAsync(x => x.Id == request.Id);

            if(category != null)
            {
                category.IsDeleted = true;

                await _unitOfWork.GetWriteRepository<Category>().UpdateAsync(category);
                await _unitOfWork.SaveAsync();
            }
            return Unit.Value;
        }
    }
}
