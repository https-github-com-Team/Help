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
    public class SubCategoryController : BaseController
    {
        private ISubCategoryService _subCategoryService;
        public SubCategoryController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }
        // GET: api/SubCategory
        [HttpGet("subCategories")]
        public async Task<IEnumerable<SubCategory>> SubCategories()
        {
            return await _subCategoryService.SubCategories();
        }

        // GET: api/city/5
        [HttpGet("SubcategoryById/{id}")]
        public async Task<SubCategory> CategoryById(int id)
        {
            var Subcategory = await _subCategoryService.GetSubCategoryById(id);
            return Subcategory;
        }

        // POST: api/addCity
        [HttpPost("addSubCategory")]
        public async Task<IActionResult> Post([FromBody] SubCategoryRequestDTO subCategoryRequestDTO)
        {
            try
            {
                var addinSubCategory = await _subCategoryService.AddSubCategory(subCategoryRequestDTO);

                return Ok(addinSubCategory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT: api/Country/5
        [HttpPut("updateSubCategory/{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] SubCategoryRequestDTO subCategoryRequestDTO)
        {
            try
            {
                var updateSubCategory = await _subCategoryService.UpdateSubCategory(id, subCategoryRequestDTO);

                return Ok(updateSubCategory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("deleteSubCategory/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var deleteSubCategory = await _subCategoryService.DeleteSubCategory(id);

                return Ok(deleteSubCategory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}