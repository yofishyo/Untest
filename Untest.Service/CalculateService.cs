using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untest.Service
{
    public class CalculateService : ICalculateService
    {
        /// <summary>
        /// 計算 小計
        /// </summary>
        /// <param name="unitPrice">單價</param>
        /// <param name="qty">數量</param>
        /// <param name="discount">折扣</param>
        /// <returns></returns>
        public decimal CalSutTotal(decimal unitPrice, int qty, decimal discount)
        {
            var result = unitPrice * qty;
            if(discount>0)
            {
                result = result * (1 - discount);
            }

            return result;
        }

        /// <summary>
        /// 四捨五入(取到 小數點第N位)
        /// </summary>
        /// <param name="value">傳入值</param>
        /// <param name="point">小數點位數(N)</param>
        /// <returns></returns>
        public decimal GetRound(decimal value, int point)
        {
            return Math.Round(value, point, MidpointRounding.AwayFromZero);
        }


        public int NumberAdd(int num1, int num2)
        {
            return num1 + num2;
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

        /// <summary>
        /// 四捨五入(取到 小數點第N位)
        /// </summary>
        /// <param name="value">傳入值</param>
        /// <param name="point">小數點位數(N)</param>
        /// <returns></returns>
        decimal GetRound(decimal value, int point);

        /// <summary>
        /// 兩數相加
        /// </summary>
        /// <param name="num1">數值1</param>
        /// <param name="num2">數值2</param>
        /// <returns></returns>
        int NumberAdd(int num1, int num2);

    }
}
