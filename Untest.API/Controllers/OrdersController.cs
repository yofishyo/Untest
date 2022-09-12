using DTO;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using Untest.Service;

namespace Untest.API.Controllers
{
    /// <summary>
    /// 訂單資料
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService _ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }

        /// <summary>
        /// 取得 (單筆)訂單資料
        /// </summary>
        /// <param name="id">訂單ID</param>
        /// <returns></returns>
        /// <response code="404">找不到該筆資料</response>    
        [HttpPost]
        [Route("Get")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(OrdersDTO), (int)HttpStatusCode.OK)]
        public ActionResult<OrdersDTO> Get(int id)
        {
            var result = _ordersService.Get(id);
            if (result is null) Response.StatusCode = (int)HttpStatusCode.NotFound;

            return result;
        }

        /// <summary>
        /// 取得 單筆訂單的總金額
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetOrderTotal")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(decimal), (int)HttpStatusCode.OK)]
        public ActionResult<decimal> GetOrderTotal(int id)
        {
            var result = _ordersService.GetOrderTotal(id);
            return result;
        }

    }
}
