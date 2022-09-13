using NUnit.Framework;
using Untest.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;

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

        #region 使用 TestCase 簡化程式碼        
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


    }
}