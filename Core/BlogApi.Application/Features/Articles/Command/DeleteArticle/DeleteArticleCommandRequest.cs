using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Command.DeleteArticle
{
    public class DeleteArticleCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
