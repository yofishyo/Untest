using DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Untest.EntityCore.Models;

namespace Untest.Service
{
    public class CustomersService : ICustomersService
    {
        private readonly NorthwindContext _dB;

        public CustomersService(NorthwindContext dB)
        {
            _dB = dB;
        }

        public CustomersDTO GetData(string customerId)
        {
            var result = _dB.Customers.Where(x => x.CustomerId == customerId)
                                .Select(x => new CustomersDTO
                                {
                                    CustomerID = x.CustomerId,
                                    CompanyName = x.CompanyName,
                                    Address = x.Address,
                                    City = x.City,
                                    Orders = x.Orders.Select(o => new OrdersDTO
                                    {
                                        OrderID = o.OrderId,
                                        OrderDate = o.OrderDate,
                                    }).Take(3).ToList(),
                                }).FirstOrDefault();

            return result;
        }

        public IEnumerable<CustomersDTO> GetList()
        {
            var result = _dB.Customers
                .Select(x => new CustomersDTO
                {
                    CustomerID = x.CustomerId,
                    CompanyName = x.CompanyName,
                    Address = x.Address,
                    City = x.City,
                });

            return result;
        }

    }

    public interface ICustomersService
    {
        /// <summary>
        /// 取得 (多筆)顧客資料
        /// </summary>
        /// <returns></returns>
        IEnumerable<CustomersDTO> GetList();

        /// <summary>
        /// 取得 (單筆)顧客資料
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        CustomersDTO GetData(string customerId);
    }

}
