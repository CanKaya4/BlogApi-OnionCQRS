using BlogApi.Application.Bases;
using BlogApi.Application.Features.Tags.Rules;
using BlogApi.Application.Interfaces.AutoMapper;
using BlogApi.Application.Interfaces.UnitOfWorks;
using BlogApi.Domain.Entities;
using Bogus;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Tags.Commands.CreateTag
{
    public class CreateTagCommandHandler : BaseHandler, IRequestHandler<CreateTagCommandRequest, Unit>
    {
        private readonly TagRules _tagRules;
        public CreateTagCommandHandler(TagRules tagRules,ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            _tagRules = tagRules;
        }

        public async Task<Unit> Handle(CreateTagCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Tag> tags = await _unitOfWork.GetReadRepository<Tag>().GetAllAsync();

            await _tagRules.TagTitleMustBeNotSame(tags, request.Name);

            Tag tag = new Tag() {Name = request.Name};

            await _unitOfWork.GetWriteRepository<Tag>().AddAsync(tag);
            await _unitOfWork.SaveAsync();

            return Unit.Value;
           
        }
    }
}
