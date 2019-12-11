using HelpApp.Core.Contracts;
using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Core.Services
{
    public class ProductService:IProductService
    {
        private readonly IUnitOfWork unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Product> AddProduct(ProductRequestDTO product)
        {
            return await unitOfWork.ProductRepository.AddProduct(product);
        }

        public async Task<Product> DeleteProduct(int id)
        {
            return await unitOfWork.ProductRepository.DeleteProduct(id);
        }

        public async Task<Product> GetProductById(int id)
        {
            return await unitOfWork.ProductRepository.GetProductById(id);
        }

        public async Task<ICollection<Product>> GetProducts()
        {
            return await unitOfWork.ProductRepository.GetProducts();
        }

        public async Task<Product> UpdateProduct(int id, ProductRequestDTO product)
        {
            return await unitOfWork.ProductRepository.UpdateProduct(id, product);
        }
    }
}
