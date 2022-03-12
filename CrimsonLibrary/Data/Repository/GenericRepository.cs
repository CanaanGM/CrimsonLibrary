using CrimsonLibrary.Data.DataAccess;
using CrimsonLibrary.Data.IReopsitory;
using CrimsonLibrary.Data.Models;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using X.PagedList;

namespace CrimsonLibrary.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DatabaseContext _datebaseContext;
        private readonly DbSet<T> _db;

        public GenericRepository(DatabaseContext datebaseContext)
        {
            _datebaseContext = datebaseContext;
            _db = _datebaseContext.Set<T>();
        }

        public async Task Delete(Guid id)
        {
            var entity = await _db.FindAsync(id);
            _db.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _db.RemoveRange(entities);
        }

        // allows for a lambda to be passed
        // so this becomes the lambda
        // x=>x.id or x.name or x.date ... etc
        public async Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null)
        {
            IQueryable<T> query = _db;
            if (includes != null)
                foreach (var includedProp in includes)
                {
                    query = query.Include(includedProp);
                }
            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<IList<T>> GetAll(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<string> includes = null)
        {
            IQueryable<T> query = _db;

            if (expression != null)
                query = query.Where(expression);

            if (includes != null)
                foreach (var includedProp in includes)
                {
                    query = query.Include(includedProp);
                }

            if (orderBy != null)
                query = orderBy(query);

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<IPagedList<T>> GetAll(
             RequestParams requestParams,
             List<string> includes = null
            )
        {
            IQueryable<T> query = _db;
            if (includes != null)
                foreach (var includedProp in includes)
                {
                    query = query.Include(includedProp);
                }
            return await query.AsNoTracking().ToPagedListAsync(requestParams.PageNumber, requestParams.PageSize);
        }

        public async Task Insert(T entity)
        {
            await _db.AddAsync(entity);
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            await _db.AddRangeAsync(entities);
        }

        public void Update(T entity)
        {
            // auto mapper ??
            _db.Attach(entity);
            _datebaseContext.Entry(entity).State = EntityState.Modified;
        }
    }
}