using DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untest.Service
{
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
