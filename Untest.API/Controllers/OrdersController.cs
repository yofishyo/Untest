using DTO;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Untest.Service;

namespace Untest.API.Controllers
{
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
        [HttpPost]
        [Route("GetData")]
        public OrdersDTO GetData(int id)
        {
            return _ordersService.GetData(id);
        }

    }
}
