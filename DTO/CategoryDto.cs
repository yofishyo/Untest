using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// 產品類別
    /// </summary>
    public class CategoryDto
    {
        /// <summary>
        /// 類別ID
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// 類別名稱
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 圖片(二進制檔)
        /// </summary>
        public byte[] Picture { get; set; }
    }
}
