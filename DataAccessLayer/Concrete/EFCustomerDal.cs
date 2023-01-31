using CoreLayer.DataAccess.EntityFramework;
namespace DataAccessLayer.Concrete;

public class EFCustomerDal : RepositoryBase<Customer, AppDbContext>, ICustomerDal
{
    //public EFCustomerDal(AppDbContext _context) : base(_context)
    //{
    //}
}
