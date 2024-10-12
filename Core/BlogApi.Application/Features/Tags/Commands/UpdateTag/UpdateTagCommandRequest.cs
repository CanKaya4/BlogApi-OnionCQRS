using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Tags.Commands.UpdateTag
{
    public class UpdateTagCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;    
    }
}
