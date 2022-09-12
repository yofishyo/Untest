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
        private readonly ICalculateService _calculateService;

        public OrdersService(NorthwindContext db, IOrderDetailService orderDetailService, ICalculateService calculateService)
        {
            _db = db;
            _orderDetailService = orderDetailService;
            _calculateService = calculateService;
        }

        public OrdersDTO Get(int orderId)
        {
            var result = _db.Orders.Where(x => x.OrderId == orderId)
                     .Select(x => new OrdersDTO
                     {
                         OrderID= x.OrderId,
                         OrderDate=x.OrderDate,
                         ShippedDate=x.ShippedDate,
                         ShipName=x.ShipName,
                         OrderDetails=_orderDetailService.GetOrders(x.OrderId)
                     }).FirstOrDefault();

            return result;
        }

        public decimal GetOrderTotal(int orderId)
        {
            var details = _db.OrderDetails.Where(x => x.OrderId == orderId).ToArray();
            if (!details.Any()) return 0;

            var subTotals = new List<decimal>();
            foreach (var item in details)
            {
                //產品小計
                var sub = _calculateService.CalSutTotal(item.UnitPrice, item.Quantity, (decimal)item.Discount);
                subTotals.Add(sub);
            }
            return subTotals.Sum();
        }
    }

    public interface IOrdersService
    {
        OrdersDTO Get(int orderId);

        /// <summary>
        /// 取得 單筆訂單的總金額
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        decimal GetOrderTotal(int orderId);

    }
}
