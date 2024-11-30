using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Queries.GetAllArticles
{
    public class GetAllArticlesQueryRequest : IRequest<IList<GetAllArticlesQueryResponse>>
    {
        public int PageNumber { get; set; } = 1; // Default sayfa numarası
        public int PageSize { get; set; } = 10;  // Default sayfa boyutu
    }
}
