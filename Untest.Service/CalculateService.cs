using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untest.Service
{
    public class CalculateService : ICalculateService
    {
        public decimal CalSutTotal(decimal unitPrice, int qty, decimal discount)
        {
            var result = unitPrice * qty;
            if(discount>0)
            {
                result = result * (1 - discount);
            }

            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }
    }


    public interface ICalculateService
    {
        /// <summary>
        /// 計算 小計
        /// </summary>
        /// <param name="unitPrice">單價</param>
        /// <param name="qty">數量</param>
        /// <param name="discount">折扣</param>
        /// <returns></returns>
        decimal CalSutTotal(decimal unitPrice, int qty, decimal discount);
    }
}
