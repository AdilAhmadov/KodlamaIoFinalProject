using BusnessLayer.Abstract;
using CoreLayer.Utilities.Results.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal OrderDal;
        public OrderManager(IOrderDal orderDal)
        {
            OrderDal = orderDal;
        }

        public IResult Add(Order product)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Order product)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Order> GetByID(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<Order>> GetTopTen(int start, int maxRows)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Order product)
        {
            throw new NotImplementedException();
        }
    }
}
