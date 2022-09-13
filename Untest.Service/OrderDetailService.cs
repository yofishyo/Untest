using DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Untest.EntityCore.Models;

namespace Untest.Service
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly NorthwindContext _db;

        public OrderDetailService(NorthwindContext db)
        {
            _db = db;
        }

        /// <summary>
        /// 取得 訂單明細
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public IEnumerable<OrderDetailDTO> GetOrders(int orderId)
        {
            var result = _db.OrderDetails.Where(x => x.OrderId == orderId)
                                .Select(x => new OrderDetailDTO
                                {
                                    OrderId = x.OrderId,
                                    ProductId=x.ProductId,
                                    UnitPrice = x.UnitPrice,
                                    Quantity = x.Quantity,
                                    Discount = x.Discount,
                                }).ToArray();

            return result;
        }        
    }

    public interface IOrderDetailService
    {
        /// <summary>
        /// 取得 訂單明細
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        IEnumerable<OrderDetailDTO> GetOrders(int orderId);
    }
}
