using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Tags.Queries.GetByIdTags
{
    public class GetByIdTagsQueryRequest : IRequest<GetByIdTagsQueryResponse>
    {
        public GetByIdTagsQueryRequest(int id)
        {
           Id = id;
        }
        public int Id { get; set; }
    }
}
