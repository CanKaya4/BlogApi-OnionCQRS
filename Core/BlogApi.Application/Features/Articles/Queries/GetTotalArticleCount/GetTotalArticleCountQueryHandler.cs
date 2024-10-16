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

namespace BlogApi.Application.Features.Articles.Queries.GetTotalArticleCount
{
    public class GetTotalArticleCountQueryHandler : BaseHandler, IRequestHandler<GetTotalArticleCountQueryRequest,int>
    {
        public GetTotalArticleCountQueryHandler(ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<int> Handle(GetTotalArticleCountQueryRequest request, CancellationToken cancellationToken)
        {
           int totalArticlesCount =await _unitOfWork.GetReadRepository<Article>().CountAsync(_=>true);
            return totalArticlesCount;
        }
    }
}
