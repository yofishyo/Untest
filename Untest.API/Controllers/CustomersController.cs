using DTO;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
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
        [Route("GetList")]
        public List<CustomersDTO> GetList()
        {
            return _customersService.GetList().ToList();
        }

        /// <summary>
        /// 取得 (單筆)顧客資料
        /// </summary>
        /// <param name="id">顧客ID</param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetData")]
        public CustomersDTO GetData(string id)
        {
            return _customersService.GetData(id);
        }        
    }
}
