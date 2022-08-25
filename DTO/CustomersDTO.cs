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
        //public CustomersDTO()
        //{
        //    this.Orders = new HashSet<OrdersDTO>();
        //}

        /// <summary>
        /// 編客ID
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


        public string ContactTitle { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 縣市
        /// </summary>
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        //public ICollection<OrdersDTO> Orders { get; set; }
    }
}
