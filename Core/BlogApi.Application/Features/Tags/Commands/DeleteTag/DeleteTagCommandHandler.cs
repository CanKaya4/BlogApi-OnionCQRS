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

namespace BlogApi.Application.Features.Tags.Commands.DeleteTag
{
    internal class DeleteTagCommandHandler : BaseHandler, IRequestHandler<DeleteTagCommandRequest,Unit>
    {
        public DeleteTagCommandHandler(ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<Unit> Handle(DeleteTagCommandRequest request, CancellationToken cancellationToken)
        {
            Tag? tag = await _unitOfWork.GetReadRepository<Tag>().GetAsync(x => x.Id == request.Id);

            if(tag != null)
            {
                tag.IsDeleted = true;
                await _unitOfWork.GetWriteRepository<Tag>().UpdateAsync(tag);
                await _unitOfWork.SaveAsync();
            }
            return Unit.Value;
        }
    }
}
