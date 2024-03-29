﻿using Untest.Service;
using NUnit.Framework;
using FluentAssertions;

namespace Untest.Service.Tests
{
    [TestFixture()]
    public class CalculateServiceTests
    {
        [Test()]
        public void GetRoundTest_輸入數字_四捨五入預期取得小數點第2位()
        {
            //arrange--------------------------------------------   
            var expected = 123.46;  //預期的結果
            decimal input = 123.4567M;

            //act-------------------------------------------------
            var actual = new CalculateService().GetRound(input, 2);

            //assert--------------------------------------------
            Assert.AreEqual(expected, actual);
        }


        #region 使用 TestCase傳入參數， 簡化程式碼        
        //[TestCase(123.45, 1, 123.5)]
        //[Test(Description = "Test_GetRound_輸入數字x_四捨五入預期取得小數點第N位")]
        //public void Test_GetRound_輸入數字x_四捨五入預期取得小數點第N位(decimal input, int point, decimal output)
        //{
        //    //arrange--------------------------------------------   

        //    //act-------------------------------------------------
        //    var actual = new CalculateService().GetRound(input, point);

        //    //assert--------------------------------------------
        //    Assert.AreEqual(output, actual);
        //}
        #endregion

        #region 使用 Fluent Assertions套件，提高程式可讀性
        [Test()]
        public void NumberAddTest_輸入2數_取得相加的結果()
        {
            var actual = new CalculateService().NumberAdd(1, 2);
            Assert.AreEqual(3, actual, "測試失敗，數字不相等");
        }

        [Test()]
        public void NumberAddTest_使用FluentAssertions寫法輸入2數_取得相加的結果()
        {
            var actual = new CalculateService().NumberAdd(1, 2);
            actual.Should().Be(3, because: "測試失敗，1+2=3");
        }
        #endregion

        [TestCase(100, 5)]
        [TestCase(100, 10)]
        public void IsDividedTest_輸入2數_預期能夠整除(int inputNum1, int inputNum2)
        {
            //arrange、act --------------------------------------------
            var actual = new CalculateService().IsDivided(inputNum1, inputNum2);
            //assert--------------------------------------------
            actual.Should().BeTrue("無法整除");
        }

        [Test()]
        public void NumberCutTest_輸入2數相減_預期等於0()
        { //arrange--------------------------------------------   
            var expected = 0;  //預期的結果

            //act-------------------------------------------------
            var actual = new CalculateService().NumberCut(5,5);

            //assert--------------------------------------------
            Assert.AreEqual(expected, actual);
        }
    }
}