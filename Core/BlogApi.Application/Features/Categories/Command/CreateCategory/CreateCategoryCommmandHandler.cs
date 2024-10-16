using BlogApi.Application.Bases;
using BlogApi.Application.Features.Categories.Rules;
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

namespace BlogApi.Application.Features.Categories.Command.CreateCategory
{
    public class CreateCategoryCommmandHandler : BaseHandler, IRequestHandler<CreateCategoryCommmandRequest, Unit>
    {
        private readonly CategoryRules _categoryRules;
        public CreateCategoryCommmandHandler(CategoryRules categoryRules,ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            _categoryRules = categoryRules;
        }

        public async Task<Unit> Handle(CreateCategoryCommmandRequest request, CancellationToken cancellationToken)
        {
            IList<Category> categories = await _unitOfWork.GetReadRepository<Category>().GetAllAsync();

            await _categoryRules.CategoryTitleMustBeNotSame(categories, request.CategoryName);

            Category category = new(request.ParentId, request.CategoryName, request.Priorty);

            await _unitOfWork.GetWriteRepository<Category>().AddAsync(category);

            await _unitOfWork.SaveAsync();

            return Unit.Value;

        }
    }
}
