using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class Repository : IRepository, IDisposable
    {
        private readonly HrmsDatabaseContext dbContext;
        public Repository(HrmsDatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        #region IRepository<T> Members

        public IQueryable<T> AsQueryable<T>() where T : class
        {
            DbSet<T> _dbSet = dbContext.Set<T>();
            return _dbSet;
        }

        public T Single<T>(Expression<Func<T, bool>> where) where T : class
        {
            DbSet<T> _dbSet = dbContext.Set<T>();
            return _dbSet.Single<T>(where);
        }

        public T SingleOrDefault<T>(Expression<Func<T, bool>> where) where T : class
        {
            DbSet<T> _dbSet = dbContext.Set<T>();
            return _dbSet.SingleOrDefault<T>(where);
        }

        public async Task<T> SingleOrDefaultAsync<T>(Expression<Func<T, bool>> where) where T : class
        {
            DbSet<T> _dbSet = dbContext.Set<T>();
            return await _dbSet.SingleOrDefaultAsync<T>(where);
        }

        public T First<T>(Expression<Func<T, bool>> where) where T : class
        {
            DbSet<T> _dbSet = dbContext.Set<T>();
            return _dbSet.First<T>(where);
        }

        public T FirstOrDefault<T>(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties) where T : class
        {
            IQueryable<T> query = dbContext.Set<T>().AsQueryable();
            foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                query = query.Include<T, object>(navigationProperty);
            return query.FirstOrDefault<T>(where);
        }

        public int Delete<T>(T entity, bool deferCommit = false) where T : class
        {
            DbSet<T> _dbSet = dbContext.Set<T>();
            _dbSet.Remove(entity);
            if (!deferCommit)
                return dbContext.SaveChanges();
            else return 0;
        }

        public int Add<T>(T entity, bool deferCommit = false) where T : class
        {
            DbSet<T> _dbSet = dbContext.Set<T>();
            _dbSet.Add(entity);
            if (!deferCommit)
                return dbContext.SaveChanges();
            else
                return 0;
        }

        public void AddList<T>(List<T> entityList) where T : class
        {
            DbSet<T> objectSet = dbContext.Set<T>();
            foreach (var entity in entityList)
            {
                objectSet.Add(entity);
            }
        }

        public async Task<int> AddAsync<T>(T entity) where T : class
        {
            DbSet<T> _dbSet = dbContext.Set<T>();
            _dbSet.Add(entity);
            return await dbContext.SaveChangesAsync();
        }

        public int Update<T>(T entity, bool deferCommit = false) where T : class
        {
            DbSet<T> _dbSet = dbContext.Set<T>();
            _dbSet.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
            if (!deferCommit)
                return dbContext.SaveChanges();
            else
                return 0;
        }

        public async Task<int> UpdateAsync<T>(T entity, bool deferCommit = false) where T : class
        {
            DbSet<T> _dbSet = dbContext.Set<T>();
            _dbSet.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
            if (!deferCommit)
                return await dbContext.SaveChangesAsync();
            else
                return 0;
        }

        public void UpdateList<T>(List<T> entityList) where T : class
        {
            try
            {
                foreach (var entity in entityList)
                {
                    dbContext.Set<T>().Attach(entity);
                    dbContext.Entry(entity).State = EntityState.Modified;
                }
                dbContext.SaveChanges();
            }
            catch (TimeoutException timeoutException)
            {
                throw timeoutException;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public IEnumerable<T> Get<T>() where T : class
        {
            DbSet<T> _dbSet = dbContext.Set<T>();
            return _dbSet;
        }

        public IQueryable<T> Get<T>(Expression<Func<T, bool>> where, bool withoutTracking, bool loadAllNavProps) where T : class
        {
            IQueryable<T> dbQuery = dbContext.Set<T>().AsQueryable();

            if (withoutTracking)
                return dbQuery.AsNoTracking().Where(where);

            return dbQuery.Where(where);
        }

        public IQueryable<T> Get<T>(params Expression<Func<T, object>>[] navigationProperties) where T : class
        {
            IQueryable<T> dbQuery = dbContext.Set<T>().AsQueryable();

            //Apply eager loading
            foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                dbQuery = dbQuery.Include<T, object>(navigationProperty);

            return dbQuery;
        }

        public IQueryable<T> Get<T>(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties) where T : class
        {
            IQueryable<T> dbQuery = dbContext.Set<T>().AsQueryable();

            //Apply eager loading
            foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                dbQuery = dbQuery.Include<T, object>(navigationProperty);

            return dbQuery.Where(where);
        }

        public async Task<List<U>> GetListAsync<U>(Expression<Func<U, bool>> condition, bool withoutTracking = false, params Expression<Func<U, object>>[] navigationProperties) where U : class
        {
            DbSet<U> objectSet = dbContext.Set<U>();
            IQueryable<U> query = objectSet.AsQueryable();
            foreach (Expression<Func<U, object>> navigationProperty in navigationProperties)
                query = query.Include<U, object>(navigationProperty);
            if (withoutTracking)
            {
                return await query.AsNoTracking().Where(condition).ToListAsync();
            }
            return await query.Where(condition).ToListAsync();
        }

        public List<U> GetList<U>(Expression<Func<U, bool>> condition, bool withoutTracking = false, params Expression<Func<U, object>>[] navigationProperties) where U : class
        {
            DbSet<U> objectSet = dbContext.Set<U>();
            IQueryable<U> query = objectSet.AsQueryable();
            foreach (Expression<Func<U, object>> navigationProperty in navigationProperties)
                query = query.Include<U, object>(navigationProperty);
            if (withoutTracking)
            {
                return query.Where(condition).AsNoTracking().ToList();
            }
            return query.Where(condition).ToList();
        }

        public T FirstOrDefaultWithoutTracking<T>(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties) where T : class
        {
            IQueryable<T> query = dbContext.Set<T>().AsQueryable();
            foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                query = query.Include<T, object>(navigationProperty);
            return query.AsNoTracking().FirstOrDefault<T>(where);
        }

        #endregion

        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

        public int Delete<T>(Expression<Func<T, bool>> where, bool deferCommit = false) where T : class
        {
            DbSet<T> _dbSet = dbContext.Set<T>();
            IEnumerable<T> objectsToRemove = _dbSet.Where(where);
            _dbSet.RemoveRange(objectsToRemove);
            if (!deferCommit)
                return dbContext.SaveChanges();
            else
                return 0;
        }

        public bool Any<T>(Expression<Func<T, bool>> where) where T : class
        {
            DbSet<T> _dbSet = dbContext.Set<T>();
            return _dbSet.Any(where);
        }

        public void DeleteList<T>(List<T> entityList) where T : class
        {
            DbSet<T> objectSet = dbContext.Set<T>();
            foreach (var entity in entityList)
            {
                objectSet.Remove(entity);
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }
    }
}