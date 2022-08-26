using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// 顧客資料
    /// </summary>
    public class CustomersDTO
    {
        public CustomersDTO()
        {
            this.Orders = new HashSet<OrdersDTO>();
        }

        /// <summary>
        /// 顧客ID
        /// </summary>
        public string CustomerID { get; set; }

        /// <summary>
        /// 公司名稱
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 聯絡人
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// 聯絡人類型
        /// </summary>
        public string ContactTitle { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 縣市
        /// </summary>
        public string City { get; set; }
        
        /// <summary>
        /// 訂單紀錄
        /// </summary>
        public ICollection<OrdersDTO> Orders { get; set; }
    }
}
