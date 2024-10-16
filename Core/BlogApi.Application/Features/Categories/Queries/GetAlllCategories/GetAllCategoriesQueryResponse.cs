using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Categories.Queries.GetAlllCategories
{
    public class GetAllCategoriesQueryResponse
    {
        public string CategoryName  { get; set; }
        public int Priorty { get; set; }
        public int ParentId { get; set; }
    }
}
