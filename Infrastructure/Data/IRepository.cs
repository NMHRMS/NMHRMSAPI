using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public interface IRepository : IDisposable
    {
        IQueryable<T> AsQueryable<T>() where T : class;
        IQueryable<T> Get<T>(params Expression<Func<T, object>>[] navigationProperties) where T : class;
        IQueryable<T> Get<T>(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties) where T : class;
        IEnumerable<T> Get<T>() where T : class;
        T Single<T>(Expression<Func<T, bool>> where) where T : class;
        T SingleOrDefault<T>(Expression<Func<T, bool>> where) where T : class;
        T First<T>(Expression<Func<T, bool>> where) where T : class;
        T FirstOrDefault<T>(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties) where T : class;
        int Delete<T>(T entity, bool deferCommit = false) where T : class;
        int Delete<T>(Expression<Func<T, bool>> where, bool deferCommit = false) where T : class;
        int Add<T>(T entity, bool deferCommit = false) where T : class;
        int Update<T>(T entity, bool deferCommit = false) where T : class;
        Task<int> UpdateAsync<T>(T entity, bool deferCommit = false) where T : class;
        int SaveChanges();
        Task<int> AddAsync<T>(T entity) where T : class;
        Task<List<U>> GetListAsync<U>(Expression<Func<U, bool>> condition, bool withoutTracking = false, params Expression<Func<U, object>>[] navigationProperties) where U : class;
        Task<int> SaveChangesAsync();
        Task<T> SingleOrDefaultAsync<T>(Expression<Func<T, bool>> where) where T : class;
        void AddList<T>(List<T> entityList) where T : class;
        List<U> GetList<U>(Expression<Func<U, bool>> condition, bool withoutTracking = false, params Expression<Func<U, object>>[] navigationProperties) where U : class;
        bool Any<T>(Expression<Func<T, bool>> where) where T : class;
        IQueryable<T> Get<T>(Expression<Func<T, bool>> where, bool withoutTracking = false, bool loadAllNavProps = true) where T : class;
        void UpdateList<T>(List<T> entityList) where T : class;
        void DeleteList<T>(List<T> entityList) where T : class;
        T FirstOrDefaultWithoutTracking<T>(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties) where T : class;
    }
}