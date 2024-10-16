using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Command.IncrementViewCountArticle
{
    public class IncrementViewCountArticleCommandRequest : IRequest
    {
        public IncrementViewCountArticleCommandRequest(int id)
        {
            Id = id;            
        }
        public int Id { get; set; }
    }
}
