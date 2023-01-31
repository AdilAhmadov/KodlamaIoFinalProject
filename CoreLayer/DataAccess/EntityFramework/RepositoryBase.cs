using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace CoreLayer.DataAccess.EntityFramework
{
    public class RepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        int counter = 0;
        //protected TContext context { get; private set; }

        //public RepositoryBase(TContext _context)
        //{
        //    context = _context;
        //}

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Set<TEntity>().Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Set<TEntity>().Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
                using (TContext context = new TContext())
                {
                    return context.Set<TEntity>().FirstOrDefault(predicate);
                }
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null)
        {
            using (TContext context = new TContext())
            {
                return predicate == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(predicate).ToList();
            }
        }

        public IEnumerable<TEntity> GetTop10(int startIndex, int maxRows)
        {
            using (TContext context = new TContext())
            {
                counter = startIndex;
                return (from obj in context.Set<TEntity>()
                        select obj).Skip(counter).Take(maxRows).ToList();
                //var data = new List<TEntity>();
                //IEnumerable<TEntity> list = context.Set<TEntity>();
                //var iterator = list.GetEnumerator();
                //for (int i = 0; i < 10; i++)
                //{
                //    if (iterator.MoveNext())
                //        data.Add(iterator.Current);
                //    else break;
                //}
                //return data;
            }
        }

        public int SaveChanges()
        {
            using (TContext context = new TContext())
            {
                return context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Set<TEntity>().Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
