using CoreLayer.EntitiesAbstraction;
using System.Linq.Expressions;

namespace CoreLayer.DataAccess
{
    public interface IRepositoryBase<T> where T : class, IEntity
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null);
        T Get(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetTop10(int startIndex, int maxRows);
        int SaveChanges();
        void Delete(T entity);
        void Add(T entity);
        void Update(T entity);
    }
}
