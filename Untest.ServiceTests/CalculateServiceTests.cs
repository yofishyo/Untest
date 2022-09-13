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
    }
}