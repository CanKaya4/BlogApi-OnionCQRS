using BlogApi.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Tags.Exceptions
{
    public class TagTitleMustBeNotSameException : BaseException
    {
        public TagTitleMustBeNotSameException() : base("Bu etiket zaten var!")
        {
            
        }
    }
}
