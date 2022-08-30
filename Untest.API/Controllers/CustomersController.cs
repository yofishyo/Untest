using DTO;

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
    /// 顧客資料
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _customersService;

        public CustomersController(ICustomersService customersService)
        {
            _customersService = customersService;
        }


        /// <summary>
        /// 取得 (多筆)顧客資料
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCustomers")]
        [Produces("application/json")]
        public ActionResult<List<CustomersDTO>> GetCustomers()
        {
            var list = _customersService.GetCustomers().ToList();
            return Ok(list);
        }

        /// <summary>
        /// 取得 (單筆)顧客資料
        /// </summary>
        /// <param name="id">顧客ID</param>
        /// <returns></returns>
        /// <response code="404">找不到該筆資料</response>   
        [HttpPost]
        [Route("Get")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(CustomersDTO), (int)HttpStatusCode.OK)]
        public ActionResult <CustomersDTO>  Get(string id)
        {
            var result = _customersService.Get(id);
            if (result is null) Response.StatusCode = (int)HttpStatusCode.NotFound;
            return result;
        }        
    }
}
