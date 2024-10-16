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

namespace BlogApi.Application.Features.Articles.Queries.GetTotalReadCountArticles
{
    public class GetTotalReadCountArticleQueryHandler : BaseHandler, IRequestHandler<GetTotalReadCountArticleQueryRequest, int>
    {
        public GetTotalReadCountArticleQueryHandler(ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<int> Handle(GetTotalReadCountArticleQueryRequest request, CancellationToken cancellationToken)
        {
           
            IList<Article> articles = await _unitOfWork.GetReadRepository<Article>().GetAllAsync();

            int totalreadCount = articles.Sum(a => a.ReadCount);


            return totalreadCount;
        }
    }
}
