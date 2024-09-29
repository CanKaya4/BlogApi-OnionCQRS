using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Command.UpdateArticle
{
    public class UpdateArticleCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int TagId { get; set; }
        public string Keyword { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IList<int> CategoryIds { get; set; }
    }
}
