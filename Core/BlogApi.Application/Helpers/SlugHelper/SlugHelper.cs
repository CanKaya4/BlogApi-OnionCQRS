using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Helpers.SlugHelper
{
    public static class SlugHelper
    {
        public static string CreateSlug(string title)
        {
            return title.ToLower() // Küçük harfe çevir
               .Replace(" ", "-") // Boşlukları tire ile değiştir
               .Replace("ş", "s")
               .Replace("ç", "c")
               .Replace("ö", "o")
               .Replace("ü", "u")
               .Replace("ı", "i")
               .Replace("ğ", "g")
               .Replace(".", "")
               .Replace(",", "")
               .Replace("'", "")
               .Replace("\"", "")
               .Replace("?", "")
               .Replace("!", "")
               .Replace("&", "")
               .Replace("#", "")
               .Replace("(", "")
               .Replace(")", "")
               .Replace("[", "")
               .Replace("]", "")
               .Replace("–", "-") // Uzun tireyi kısa tire ile değiştir
               .Replace("--", "-") // Çift tireleri teke indir
               .Trim('-'); // Baş ve sondaki tireleri temizle
        }
    }
}
