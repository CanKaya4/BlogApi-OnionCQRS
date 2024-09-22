using BlogApi.Domain.Common;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Interfaces.Repositories
{
    public interface IReadRepository<T> where T : class, IEntityBase, new()
    {
        //Predicate : sorgu yazmamızı sağlar, örnek  olarak IsDeleted = 1 olanlar gelsin gibi vs gibi.
        //Inculude : Tabloları birleştirebilmek için yani join işlemi için kullanılır.
        //Order By : İstenilen bir property'e göre sıralamak yapmak için kullanılır. Örnek olarak CreatedDate'e göre bir sıralama için kullanılır
        // Tracking : Read işlemlerinde enable olmaması gereken bir yapı.
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false); //Veri çekmek için

        Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false, int currentPage = 1, int pageSize = 3); //Sayfalama için

        Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false); //Tek bir veri getirmek için

        IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false); //IQueryable olarak bir veri getirmek istediğimde kullanıcağım. IQueryable sorgu alınmış fakat daha işlenmemiş oluyor.

        Task<int> CountAsync(Expression<Func<T, bool>>? predicate); //Toplam sayıyı almak için
    }


}
