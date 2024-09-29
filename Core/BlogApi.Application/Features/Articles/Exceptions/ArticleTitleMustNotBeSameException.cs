using BlogApi.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Exceptions
{
    public class ArticleTitleMustNotBeSameException : BaseExceptions
    {
        public ArticleTitleMustNotBeSameException() : base("Makale başlığı zaten var!")
        {
            
        }
    }
}
