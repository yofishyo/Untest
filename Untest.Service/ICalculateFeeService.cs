using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untest.Service
{
    public interface ICalculateFeeService
    {
        /// <summary>
        /// 計算金額
        /// </summary>
        /// <param name="defaultFee">初始金額</param>
        /// <returns></returns>
        float CalculateFee(int defaultFee);
    }
}
