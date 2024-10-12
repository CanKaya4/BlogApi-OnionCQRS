using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Tags.Commands.CreateTag
{
    public class CreateTagCommandRequest : IRequest<Unit>
    {
        public string  Name{ get; set; }
    }
}
