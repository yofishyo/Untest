using DTO;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using Untest.Service;
using Untest.Utility.Exceptions;

namespace Untest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// 取得 (單筆)產品類別
        /// </summary>
        /// <param name="id"></param>
        /// <response code="404">找不到該筆資料</response>    
        /// <returns></returns>
        [HttpPost]
        [Route("Get")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(CategoryDto), (int)HttpStatusCode.OK)]
        public ActionResult<CategoryDto> Get(int id)
        {
            var result = _categoryService.Get(id);
            if (result is null) Response.StatusCode = (int)HttpStatusCode.NotFound;

            return result;
        }

        /// <summary>
        /// 取得 (多筆)產品類別
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCategorys")]
        [Produces("application/json")]
        public ActionResult<List<CategoryDto>> GetCategorys()
        {
            var list = _categoryService.GetCategorys();
            return Ok(list);
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Create")]
        [ProducesResponseType(typeof(CategoryDto), (int)HttpStatusCode.OK)]
        public ActionResult Create(CategoryDto dto)
        {
            var result = _categoryService.Create(dto);
            return Ok(result);
        }

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Delete")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public ActionResult Delete(int id)
        {
            var result = _categoryService.DeleteById(id);
            return Ok(result);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Update")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public ActionResult Update(CategoryDto dto)
        {
            var result = _categoryService.Update(dto);
            return Ok(result);
        }

    }
}
