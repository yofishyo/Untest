using NUnit.Framework;
using Untest.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untest.Utility.Extensions.Tests
{
    [TestFixture()]
    public class StringExtensionsTests
    {
        [Test(Description= "Test_ToCurrencyString_數字小數點第1位_預期取得字串型別的整數")]
        public void Test_ToCurrencyString_數字小數點第1位_預期取得字串型別的整數()
        {
            //arrange--------------------------------------------
            #region 直接 new 出實體，未隔離
            //注：此為public class，not static class，所以未使用DI隔離class
            #endregion
            var stringExtensions = new StringExtensions();    
            var sut = 123.4;       //被測物
            var expected = "123";  //預期的結果

            //act-------------------------------------------------
            var result = stringExtensions.ToCurrencyString(sut);

            //assert--------------------------------------------
            Assert.AreEqual(expected, result);
        }

        #region 同個method，傳入多個sut
        //[Test(Description = "Test_ToCurrencyString_數字小數點第2位_預期取得字串型別的整數")]
        //public void Test_ToCurrencyString_數字小數點第2位_預期取得字串型別的整數()
        //{
        //    //arrange--------------------------------------------          
        //    var stringExtensions = new StringExtensions();
        //    var sut = 123.45;       //被測物
        //    var expected = "123";  //預期的結果

        //    //act-------------------------------------------------
        //    var result = stringExtensions.ToCurrencyString(sut);

        //    //assert--------------------------------------------
        //    Assert.AreEqual(expected, result);
        //}

        //[Test(Description = "Test_ToCurrencyString_數字小數點第3位_預期取得字串型別的整數")]
        //public void Test_ToCurrencyString_數字小數點第3位_預期取得字串型別的整數()
        //{
        //    //arrange--------------------------------------------          
        //    var stringExtensions = new StringExtensions();
        //    var sut = 123.456;       //被測物
        //    var expected = "123";  //預期的結果

        //    //act-------------------------------------------------
        //    var result = stringExtensions.ToCurrencyString(sut);

        //    //assert--------------------------------------------
        //    Assert.AreEqual(expected, result);
        //}
        #endregion

        #region 測試失敗
        //[Test(Description = "Test_ToCurrencyString_數字小數點第4位_預期取得字串型別的整數")]
        //public void Test_ToCurrencyString_數字小數點第4位_預期取得字串型別的整數()
        //{
        //    //arrange--------------------------------------------          
        //    var stringExtensions = new StringExtensions();
        //    var sut = 123.4567;       //被測物
        //    var expected = "123.";  //預期的結果

        //    //act-------------------------------------------------
        //    var result = stringExtensions.ToCurrencyString(sut);

        //    //assert--------------------------------------------
        //    Assert.AreEqual(expected, result);
        //}
        #endregion

    }
}