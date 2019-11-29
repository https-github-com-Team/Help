using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpApp.Core.Contracts;
using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace HelpApp.WebApi.Controllers
{
    public class CategoryController : BaseController
    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        // GET: api/City
        [HttpGet("categories")]
        public async Task<IEnumerable<Category>> Cities()
        {
            return await _categoryService.Categories();
        }

        // GET: api/city/5
        [HttpGet("categoryById/{id}")]
        public async Task<Category> CategoryById(int id)
        {
            var category = await _categoryService.GetCategoryById(id);
            return category;
        }

        // POST: api/addCity
        [HttpPost("addCategory")]
        public async Task<IActionResult> Post([FromBody] CategoryRequestDTO category)
        {
            try
            {
                var addinCategory = await _categoryService.AddCategory(category);

                return Ok(addinCategory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT: api/Country/5
        [HttpPut("updateCategory/{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CategoryRequestDTO category)
        {
            try
            {
                var updateCategory = await _categoryService.UpdateCategory(id, category);

                return Ok(updateCategory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("deleteCategory/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var deleteCategory = await _categoryService.DeleteCategory(id);

                return Ok(deleteCategory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}