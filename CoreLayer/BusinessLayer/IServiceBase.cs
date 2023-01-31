
namespace CoreLayer.BusinessLayer
{
    public interface IServiceBase<T>
    {
        IDataResult<IEnumerable<T>> GetAll();
        IDataResult<T> GetByID(int Id);
        IDataResult<IEnumerable<T>> GetTopTen(int start, int maxRows);
        IResult Add(T product);
        IResult Update(T product);
        IResult Delete(T product);
    }
}
