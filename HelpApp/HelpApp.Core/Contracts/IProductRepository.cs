using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Core.Contracts
{
    public interface IProductRepository
    {
        Task<ICollection<Product>> GetProducts();
        Task<Product> GetProductById(int id);
        Task<Product> AddProduct(ProductRequestDTO product);
        Task<Product> UpdateProduct(int id, ProductRequestDTO product);
        Task<Product> DeleteProduct(int id);
    }
}
