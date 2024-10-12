using BlogApi.Application.Bases;
using BlogApi.Application.Features.Tags.Exceptions;
using BlogApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Tags.Rules
{
    public class TagRules : BaseRules
    {
        public Task TagTitleMustBeNotSame(IList<Tag> tags, string requestName)
        {
            if (tags.Any(x => x.Name == requestName))
            {
                throw new TagTitleMustBeNotSameException();
            }

            return Task.CompletedTask;
        }
    }
}
