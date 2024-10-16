using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Categories.Command.CreateCategory
{
    public class CreateCategoryCommmandRequest : IRequest<Unit>
    {
        public int ParentId { get; set; }
        public int Priorty { get; set; }
        public string CategoryName { get; set; }
    }
}
