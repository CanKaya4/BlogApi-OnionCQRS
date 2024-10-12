using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Tags.Commands.DeleteTag
{
    public class DeleteTagCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
