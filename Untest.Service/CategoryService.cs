using DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Untest.EntityCore.Models;
using Untest.Utility.Exceptions;

namespace Untest.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly NorthwindContext _db;
        public CategoryService(NorthwindContext db)
        {
            _db = db;
        }

        public bool Create(CategoryDto dto)
        {
            var efData = Map(dto);

            _db.Categories.Add(efData);
            var result = _db.SaveChanges();

            return result > 0 ? true : false;
        }

        private Category Map(CategoryDto dto)
        {
            var ef = new Category
            {
                //CategoryId = dto.CategoryId,
                CategoryName = dto.CategoryName,
                Description = dto.Description,
                Picture = dto.Picture,
            };

            return ef;
        }

        public bool DeleteById(int id)
        {
            var data = _db.Categories.Find(id);

            if (data is null) return false;

            _db.Categories.Remove(data);
            _db.SaveChanges();
            return true;
        }

        public CategoryDto Get(int id)
        {
            var result = _db.Categories.Where(x => x.CategoryId == id)
                            .Select(x => new CategoryDto
                            {
                                CategoryId = x.CategoryId,
                                CategoryName = x.CategoryName,
                                Description = x.Description,
                                //Picture = x.Picture,
                            }).FirstOrDefault();

            return result;
        }

        public List<CategoryDto> GetCategorys()
        {
            var result = _db.Categories
                               .Select(x => new CategoryDto
                               {
                                   CategoryId = x.CategoryId,
                                   CategoryName = x.CategoryName,
                                   Description = x.Description,
                                   //Picture = x.Picture,
                               }).ToList();

            return result;
        }

        public bool Update(CategoryDto dto)
        {
            var ef = _db.Categories.Find(dto.CategoryId);

            if (ef is null) return false;

            ef.CategoryName = dto.CategoryName;
            ef.Description = dto.Description;

            _db.Categories.Update(ef);
            _db.SaveChanges();
            return true;
        }
    }

    /// <summary>
    /// 產品類別
    /// </summary>
    public interface ICategoryService
    {
        /// <summary>
        /// 取得 單筆
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CategoryDto Get(int id);

        /// <summary>
        /// 取得 多筆
        /// </summary>
        /// <returns></returns>
        List<CategoryDto> GetCategorys();

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="id"></param>
        bool DeleteById(int id);

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        bool Create(CategoryDto dto);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        bool Update(CategoryDto dto);
    }
}
