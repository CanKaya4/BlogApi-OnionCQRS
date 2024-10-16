using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Queries.GetTotalArticleCount
{
    public class GetTotalArticleCountQueryRequest : IRequest<int>
    {
    }
}
