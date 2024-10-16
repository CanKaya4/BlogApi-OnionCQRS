using BlogApi.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Categories.Exceptions
{
    public class CategoryTitleMustNotBeSameException : BaseException
    {
        public CategoryTitleMustNotBeSameException() : base("Kategori ismi zaten var!")
        {
            
        }
    }
}
