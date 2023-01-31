

using BusnessLayer.Abstract;
using BusnessLayer.FeedbackMessages;
using CoreLayer.EntitiesAbstraction;
using CoreLayer.Utilities.Results;
using CoreLayer.Utilities.Results.Abstract;
using DataAccessLayer.Abstract;

namespace BusnessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal CategoryDal;
        public CategoryManager(ICategoryDal _CategoryDal)
        {
            CategoryDal = _CategoryDal;
        }
        public IResult Add(Category product)
        {
            CategoryDal.Add(product);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Category product)
        {
            CategoryDal.Delete(product);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IDataResult<IEnumerable<Category>> GetAll()
        {
            return new SuccessDataResult<IEnumerable<Category>>(CategoryDal.GetAll(), Messages.CategoriesListed);
        }

        public IDataResult<Category> GetByID(int Id)
        {
            return new SuccessDataResult<Category>(CategoryDal.Get(x=>x.CategoryID== Id));
        }

        public IDataResult<IEnumerable<Category>> GetTopTen(int start, int maxRows)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Category product)
        {
            CategoryDal.Update(product);
            return new SuccessResult(Messages.CategoryUpdated);
        }
    }
}
