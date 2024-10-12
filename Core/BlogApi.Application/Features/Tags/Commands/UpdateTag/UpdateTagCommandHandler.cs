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

namespace BlogApi.Application.Features.Tags.Commands.UpdateTag
{
    public class UpdateTagCommandHandler : BaseHandler,IRequestHandler<UpdateTagCommandRequest,Unit>
    {
        public UpdateTagCommandHandler(ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<Unit> Handle(UpdateTagCommandRequest request, CancellationToken cancellationToken)
        {
            Tag? tag = await _unitOfWork.GetReadRepository<Tag>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            if(tag != null)
            {
                var map = _mapper.Map<Tag, UpdateTagCommandRequest>(request);

                await _unitOfWork.GetWriteRepository<Tag>().UpdateAsync(map);
                await _unitOfWork.SaveAsync();
            }
            return Unit.Value;
        }
    }
}
