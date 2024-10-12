using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Tags.Queries.GetAllTags
{
    public class GetAllTagsQueryResponse
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
