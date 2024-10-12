using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Tags.Queries.GetAllTags
{
    public class GetAllTagsQueryRequest : IRequest<IList<GetAllTagsQueryResponse>>
    {

    }
}
