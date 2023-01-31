namespace DataAccessLayer.Concrete;

public class EFOrderDal : RepositoryBase<Order, AppDbContext>, IOrderDal
{
    //public EFOrderDal(AppDbContext _context) : base(_context)
    //{
    //}
}
