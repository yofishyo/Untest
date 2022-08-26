using DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Untest.EntityCore.Models;

namespace Untest.Service
{
    public class OrdersService : IOrdersService
    {
        private readonly NorthwindContext _db;
        private readonly IOrderDetailService _orderDetailService;

        public OrdersService(NorthwindContext db, IOrderDetailService orderDetailService)
        {
            _db = db;
            _orderDetailService = orderDetailService;
        }

        public OrdersDTO GetData(int orderId)
        {
            var result = _db.Orders.Where(x => x.OrderId == orderId)
                     .Select(x => new OrdersDTO
                     {
                         OrderID= x.OrderId,
                         OrderDate=x.OrderDate,
                         ShippedDate=x.ShippedDate,
                         ShipName=x.ShipName,
                         OrderDetails=_orderDetailService.GetList(x.OrderId)
                     }).FirstOrDefault();

            return result;
        }

    }

    public interface IOrdersService
    {
        OrdersDTO GetData(int orderId);
    }
}
