using NUnit.Framework;
using Untest.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using DTO;

namespace Untest.Service.Tests
{
    [TestFixture()]
    public class OrdersServiceTests
    {
        private readonly ICalculateService _stubCalculateService;
        private readonly IOrderDetailService _stubOrderDetailService;

        public OrdersServiceTests()
        {
            // 建立模擬物件
            _stubCalculateService = Substitute.For<ICalculateService>();
            _stubOrderDetailService = Substitute.For<IOrderDetailService>();
        }


        [Test(Description = "GetOrderTotalTest_取得單筆訂單的總金額_取得小計加總")]
        public void GetOrderTotalTest_取得單筆訂單的總金額_取得小計加總()
        {
            //arrange--------------------------------------------   
            var orderId = 1;

            #region 隔離相依性物件
            var fakeDetails = new List<OrderDetailDTO>()
                                    {
                                        new OrderDetailDTO() { OrderId = 1, UnitPrice=10,Quantity=10, Discount=0 },
                                    };
            //模擬回傳值
            _stubOrderDetailService.GetOrders(orderId).Returns(x => { return fakeDetails; });
            _stubCalculateService.CalSutTotal(10, 10, 0).Returns(100);

            //使用參數匹配器 Arg.Any<Type>，忽略傳入的參數內容
            //_stubCalculateService.CalSutTotal(Arg.Any<decimal>(), Arg.Any<int>(), Arg.Any<decimal>()).Returns(100);
            #endregion

            //verify
            var expected = 100;

            //建立待測物sut
            var sut = new OrdersService(null, _stubOrderDetailService, _stubCalculateService);

            //act-------------------------------------------------
            var actual = sut.GetOrderTotal(orderId);

            //assert--------------------------------------------
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "GetOrderTotalTest_查無訂單id_取得0")]
        public void GetOrderTotalTest_查無訂單id_取得0()
        {
            //arrange--------------------------------------------   
            var orderId = 1;

            #region 隔離相依性物件
            //模擬回傳值
            _stubOrderDetailService.GetOrders(orderId).Returns(x => { return new List<OrderDetailDTO>(); });
            //使用參數匹配器 Arg.Any<Type>，忽略傳入的參數內容
            _stubCalculateService.CalSutTotal(Arg.Any<decimal>(), Arg.Any<int>(), Arg.Any<decimal>()).Returns(100);
            #endregion

            //verify
            var expected = 0;

            //建立待測物sut
            var sut = new OrdersService(null, _stubOrderDetailService, _stubCalculateService);

            //act-------------------------------------------------
            var actual = sut.GetOrderTotal(orderId);

            //assert--------------------------------------------
            Assert.AreEqual(expected, actual);
        }

    }
}