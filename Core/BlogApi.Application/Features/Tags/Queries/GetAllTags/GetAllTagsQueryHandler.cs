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

namespace BlogApi.Application.Features.Tags.Queries.GetAllTags
{
    public class GetAllTagsQueryHandler :BaseHandler, IRequestHandler<GetAllTagsQueryRequest, IList<GetAllTagsQueryResponse>>
    {
        public GetAllTagsQueryHandler(ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<IList<GetAllTagsQueryResponse>> Handle(GetAllTagsQueryRequest request, CancellationToken cancellationToken)
        {
            var tags = await _unitOfWork.GetReadRepository<Tag>().GetAllAsync();

            return _mapper.Map<GetAllTagsQueryResponse, Tag>(tags);
        }
    }
}
