using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// 訂單明細檔
    /// </summary>
    public class OrderDetailDTO
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        /// <summary>
        /// 單價
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 數量
        /// </summary>
        public short Quantity { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        public float Discount { get; set; }

        public virtual OrdersDTO Order { get; set; }
    }
}
