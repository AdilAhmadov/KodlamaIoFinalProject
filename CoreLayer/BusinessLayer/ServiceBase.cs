using CoreLayer.DataAccess;

namespace CoreLayer.BusinessLayer
{
    public class ServiceBase<TEntity, T> : IServiceBase<TEntity>
        where TEntity : class
    {
        IBusinessDal businessDal;

        public ServiceBase(IBusinessDal _businessDal)
        {
            businessDal = _businessDal; 
        }
        public IResult Add(TEntity product)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(TEntity product)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<TEntity> GetByID(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<TEntity>> GetTopTen(int start, int maxRows)
        {
            throw new NotImplementedException();
        }

        public IResult Update(TEntity product)
        {
            throw new NotImplementedException();
        }
    }
}
