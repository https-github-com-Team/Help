using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpApp.Core.Contracts;
using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using HelpApp.WebApi.Extenions;
using HelpApp.WebApi.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace HelpApp.WebApi.Controllers
{
    public class ProductController : BaseController
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("products")]
        public async Task<IEnumerable<Product>> Products()
        {
            return await _productService.GetProducts();
        }

        // GET: api/city/5
        [HttpGet("ProductById/{id}")]
        public async Task<Product> ProductById(int id)
        {
            var product = await _productService.GetProductById(id);
            return product;
        }

        // POST: api/addCity
        [HttpPost("addProduct")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Post([SwaggerParameter(Required =true),FromForm] ProductRequestDTO product)
        {
            try
            {
                var addProduct = await _productService.AddProduct(product);
                return Ok(addProduct);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT: api/Country/5
        [HttpPut("updateProduct/{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ProductRequestDTO product)
        {
            try
            {
                var updateProduct = await _productService.UpdateProduct(id, product);
                return Ok(updateProduct);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("deleteProduct/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var deleteProduct = await _productService.DeleteProduct(id);

                return Ok(deleteProduct);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }



    }
}