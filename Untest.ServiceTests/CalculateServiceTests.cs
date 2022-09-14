using Untest.Service;
using NUnit.Framework;
using FluentAssertions;

namespace Untest.Service.Tests
{
    [TestFixture()]
    public class CalculateServiceTests
    {
        [Test()]
        public void Test_GetRound_輸入數字_四捨五入預期取得小數點第N位()
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
            Assert.AreEqual(3,actual, "測試失敗，數字不相等");
        }

        [Test()]
        public void NumberAddTest_使用FluentAssertions寫法輸入2數_取得相加的結果()
        {
            var actual = new CalculateService().NumberAdd(1, 2);
            actual.Should().Be(3, because: "1+2=3");
        }
        #endregion
    }
}