using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// 訂單主檔
    /// </summary>
    public class OrdersDTO
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        //public Nullable<int> EmployeeID { get; set; }

        /// <summary>
        /// 訂購日期
        /// </summary>
        public Nullable<System.DateTime> OrderDate { get; set; }
        /// <summary>
        /// 發貨日期
        /// </summary>
        public Nullable<System.DateTime> ShippedDate { get; set; }
        /// <summary>
        /// 發貨商
        /// </summary>
        public string ShipName { get; set; }
        /// <summary>
        /// 發貨地址
        /// </summary>
        public string ShipAddress { get; set; }
        /// <summary>
        /// 發貨地址(城市)
        /// </summary>
        public string ShipCity { get; set; }

        /// <summary>
        /// 訂單明細
        /// </summary>
        public virtual ICollection<OrderDetailDTO> OrderDetails { get; set; }
    }
}
