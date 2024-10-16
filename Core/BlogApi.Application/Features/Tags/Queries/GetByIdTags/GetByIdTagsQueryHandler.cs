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

namespace BlogApi.Application.Features.Tags.Queries.GetByIdTags
{
    public class GetByIdTagsQueryHandler : BaseHandler, IRequestHandler<GetByIdTagsQueryRequest,GetByIdTagsQueryResponse>
    {
        public GetByIdTagsQueryHandler(ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<GetByIdTagsQueryResponse> Handle(GetByIdTagsQueryRequest request, CancellationToken cancellationToken)
        {
            var tag = await _unitOfWork.GetReadRepository<Tag>().GetAsync(x => x.Id == request.Id);

            return _mapper.Map<GetByIdTagsQueryResponse, Tag>(tag);
        }
    }
}
