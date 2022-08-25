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
                                }).FirstOrDefault();

            return result;
        }

        public IEnumerable<CustomersDTO> GetList()
        {
            var result = _dB.Customers.Select(x => new CustomersDTO
            {
                CustomerID = x.CustomerId,
                CompanyName = x.CompanyName,
                Address = x.Address,
                City = x.City,
            });

            return result;
        }

    }
}
