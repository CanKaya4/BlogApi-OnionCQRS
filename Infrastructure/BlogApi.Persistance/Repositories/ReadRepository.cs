using BlogApi.Application.Interfaces.Repositories;
using BlogApi.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class, IEntityBase, new()
    {
        // IQueryable : Sadece bir sorgu, daha işlenmemiş bir sorgu.
        //Read işlemi yani okuma işlemi yapıyoruz, EF Core'un tracking mekanizmasının okuma işlemi yaparken çektiğimiz verileri takip etmesine gerek yok. Bundan dolayı ReadRepository içerisideki metotlarım için takip mekanizmasını kaldırıyorum ki performans açısından faydası olsun.
        private readonly DbContext _dbContext;
        public ReadRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        private DbSet<T> Table { get => _dbContext.Set<T>(); }
        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking)  //Herhangi bir update vs yapmayacağım için Tracking mekanizmasını devre dışı bırakıyorum.
                queryable = queryable.AsNoTracking();
            if (include is not null) // Veriyi çekerken join işlemi var mı diye bakıyorun
                queryable = include(queryable);
            if (predicate is not null) // Veriyi çekerken bir koşul var mı diye bakıyorum.
                queryable = queryable.Where(predicate);
            if (orderBy is not null) // Veriyi çekerken bir sıralama var mı diye bakıyorum.
                return await orderBy(queryable).ToListAsync();

            return await queryable.ToListAsync();

        }
        public async Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false, int currentPage = 1, int pageSize = 3)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include is not null)
                queryable = include(queryable);
            if (predicate is not null)
                queryable = queryable.Where(predicate);
            if (orderBy is not null)
                return await orderBy(queryable).Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();

            return await queryable.Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
        }
        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include is not null)
                queryable = include(queryable);

            //queryable = queryable.Where(predicate);

            return await queryable.FirstOrDefaultAsync(predicate);

        }
        public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate)
        {
            Table.AsNoTracking();
            if (predicate is not null)
                Table.Where(predicate);

            return await Table.CountAsync();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false)
        {
            if (!enableTracking)
                Table.AsNoTracking();

            return Table.Where(predicate);
        }

    }
}
