using BusnessLayer.Abstract;
using BusnessLayer.FeedbackMessages;
using CoreLayer.Utilities.Results;
using CoreLayer.Utilities.Results.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace BusnessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal ProductDal;
        public ProductManager(IProductDal _ProductDal)
        {
            ProductDal = _ProductDal;
        }
        public IResult Add(Product product)
        {
            ProductDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            ProductDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<IEnumerable<Product>> GetAll()
        {
           return new SuccessDataResult<IEnumerable<Product>>(ProductDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<Product> GetByID(int Id)
        {
            return new SuccessDataResult<Product>(ProductDal.Get(x=>x.ProductID == Id), Messages.ProductWithIDListed(Id));
        }

        public IDataResult<IEnumerable<Product>> GetTopTen(int start, int maxRows)
        {
            return new SuccessDataResult<IEnumerable<Product>>(ProductDal.GetTop10(start, maxRows), Messages.ProductListed);
        }

        public IResult Update(Product product)
        {
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
