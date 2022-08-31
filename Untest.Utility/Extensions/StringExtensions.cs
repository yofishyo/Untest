using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Untest.Utility.Extensions
{
    public class StringExtensions
    {
        /// <summary>
        /// 數字轉字串，取到小數點第0位
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ToCurrencyString(object input)
        {
            var isNumber = input != null ? Regex.IsMatch(input.ToString(), @"\d") : false;
            return isNumber ? string.Format("{0:N0}", input) : "0";
        }

        //string Formatting of 1054.32179:
        //          N:                     1,054.32 
        //          N0:                    1,054 
        //          N1:                    1,054.3 
        //          N2:                    1,054.32 
        //          N3:                    1,054.322 

    }
}
