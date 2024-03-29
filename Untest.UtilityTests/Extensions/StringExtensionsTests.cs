﻿using NUnit.Framework;

namespace Untest.Utility.Extensions.Tests
{
    [TestFixture()]
    public class StringExtensionsTests
    {
        [Test(Description = "Test_ToCurrencyString_輸入數字小數點後第1位_預期取得字串型別的整數")]
        public void Test_ToCurrencyString_輸入數字小數點後第1位_預期取得字串型別的整數()
        {
            //arrange--------------------------------------------
            #region 此為public class，直接 new 出實體
            //注：此為public class，not static class，所以未使用interface隔離class
            #endregion
            var stringExtensions = new StringExtensions();
            var sut = 123.4;       //待測物
            var expected = "123";  //預期的結果

            //act-------------------------------------------------
            var actual = stringExtensions.ToCurrencyString(sut);

            //assert--------------------------------------------
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Test_ToCurrencyString_輸入字串一二三_預期取得字串0")]
        public void Test_ToCurrencyString_輸入字串一二三_預期取得字串0()
        {
            //arrange--------------------------------------------           
            var stringExtensions = new StringExtensions();
            var sut = "一二三";       //待測物
            var expected = "0";  //預期的結果

            //act-------------------------------------------------
            var actual = stringExtensions.ToCurrencyString(sut);

            //assert--------------------------------------------
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Test_ToCurrencyString_輸入字串123_預期取得字串123")]
        public void Test_ToCurrencyString_輸入字串123_預期取得字串123()
        {
            //arrange--------------------------------------------           
            var stringExtensions = new StringExtensions();
            var sut = "123";       //待測物
            var expected = "123";  //預期的結果

            //act-------------------------------------------------
            var actual = stringExtensions.ToCurrencyString(sut);

            //assert--------------------------------------------
            Assert.AreEqual(expected, actual);
        }

        #region 同個method，傳入多個sut
        //[Test(Description = "Test_ToCurrencyString_輸入數字小數點後第2位_預期取得字串型別的整數")]
        //public void Test_ToCurrencyString_輸入數字小數點後第2位_預期取得字串型別的整數()
        //{
        //    //arrange--------------------------------------------          
        //    var stringExtensions = new StringExtensions();
        //    var sut = 123.45;       //待測物
        //    var expected = "123";  //預期的結果

        //    //act-------------------------------------------------
        //    var actual = stringExtensions.ToCurrencyString(sut);

        //    //assert--------------------------------------------
        //    Assert.AreEqual(expected, actual);
        //}

        //[Test(Description = "Test_ToCurrencyString_輸入數字小數點後第3位_預期取得字串型別的整數")]
        //public void Test_ToCurrencyString_輸入數字小數點後第3位_預期取得字串型別的整數()
        //{
        //    //arrange--------------------------------------------          
        //    var stringExtensions = new StringExtensions();
        //    var sut = 123.456;       //待測物
        //    var expected = "123";  //預期的結果

        //    //act-------------------------------------------------
        //    var actual = stringExtensions.ToCurrencyString(sut);

        //    //assert--------------------------------------------
        //    Assert.AreEqual(expected, actual);
        //}
        #endregion

        #region 測試失敗
        //[Test(Description = "Test_ToCurrencyString_輸入數字小數點後第4位_預期取得字串型別的整數")]
        //public void Test_ToCurrencyString_輸入數字小數點後第4位_預期取得字串型別的整數()
        //{
        //    //arrange--------------------------------------------          
        //    var stringExtensions = new StringExtensions();
        //    var sut = 123.4567;       //被測物
        //    var expected = "123.";  //預期的結果

        //    //act-------------------------------------------------
        //    var actual = stringExtensions.ToCurrencyString(sut);

        //    //assert--------------------------------------------
        //    Assert.AreEqual(expected, actual);
        //}
        #endregion

        #region 使用 TestCase 簡化程式碼
        //[TestCase(123.4567, "123")]
        //[TestCase(123.456, "123")]
        //[TestCase(123.45, "123")]
        //[TestCase(123.4, "123")]
        //[Test(Description = "Test_ToCurrencyString_輸入數字小數點後第N位_預期取得字串型別的整數")]
        //public void Test_ToCurrencyString_輸入數字小數點後第N位_預期取得字串型別的整數(object sut, string expected)
        //{
        //    //arrange--------------------------------------------           
        //    var stringExtensions = new StringExtensions();

        //    //act-------------------------------------------------
        //    var actual = stringExtensions.ToCurrencyString(sut);

        //    //assert--------------------------------------------
        //    Assert.AreEqual(expected, actual);
        //}
        #endregion

    }
}