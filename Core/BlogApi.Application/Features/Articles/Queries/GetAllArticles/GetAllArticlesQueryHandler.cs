using BlogApi.Application.Interfaces.UnitOfWorks;
using BlogApi.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Queries.GetAllArticles
{
    public class GetAllArticlesQueryHandler : IRequestHandler<GetAllArticlesQueryRequest, IList<GetAllArticlesQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAllArticlesQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IList<GetAllArticlesQueryResponse>> Handle(GetAllArticlesQueryRequest request, CancellationToken cancellationToken)
        {
            var articles = await _unitOfWork.GetReadRepository<Article>().GetAllAsync();
            List<GetAllArticlesQueryResponse> response = new();  
            foreach(var item in articles)
            {
               response.Add(new GetAllArticlesQueryResponse()
                {
                    Title = item.Title,
                    CategoryId = item.CategoryId,
                    Content = item.Content
                });
            }
            return response;
        }
    }
}
