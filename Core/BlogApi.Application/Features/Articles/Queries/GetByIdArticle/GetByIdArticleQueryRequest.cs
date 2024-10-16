using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Queries.GetByIdArticle
{
    public class GetByIdArticleQueryRequest : IRequest<GetByIdArticleQueryResponse>
    {
        public GetByIdArticleQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
