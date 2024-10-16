using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Categories.Command.UpdateCategory
{
    public class UpdateCategoryCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int Priorty { get; set; }
        public string CategoryName { get; set; }
        public IList<int> ArticleIds { get; set; }  
    }
}
