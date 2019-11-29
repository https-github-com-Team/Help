using HelpApp.Core.Contracts;
using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using HelpApp.Core.Services;
using HelpApp.Infrastructure.Db;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelpApp.WebApi.Extenions;
using HelpApp.WebApi.Utilities;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace HelpApp.Infrastructure.Repositories
{

    public class ProductRepository : IProductRepository
    {
        public HelpDbContext _db { get; set; }

        public ProductRepository(HelpDbContext db)
        {
            _db = db;
        }
        public async Task<Product> AddProduct(ProductRequestDTO product)
        {
            try
            {
                
                //List<IFormFile> files = new List<IFormFile>();
                //if (product.Img.Count>0)
                //{
                //    foreach (var item in product.Img)
                //    {
                //        if (!item.IsImage())
                //        {
                //            return null;
                //        }
                //        if (!item.IsLessThan(2))
                //        {
                //            return null;
                //        }

                //        files.Add(item);
                //    }
                //}
                //else
                //{
                //    return null;
                //}
                

                Product product1 = new Product()
                {
                    Name = product.Name,
                    Description= product.Description,
                    CategoryId = product.CategoryId,
                    CityId = product.CityId,
                    PersonId = product.PersonId,
                    PublishDate = product.PublishDate,
                    EndedDate = product.EndedDate
                };

                _db.Products.Add(product1);
               await _db.SaveChangesAsync();
                var ProId =  _db.Products.LastOrDefault().Id;
                //foreach (var item in files)
                //{

                //    var image =await item.Save("HelpApp.Infrastructure", "Image");
                //    _db.Photos.Add(new Photo()
                //    {
                //        Path = image,
                //        ProductId = ProId
                //    });
                //   await _db.SaveChangesAsync();
                //}
                return product1;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<Product> DeleteProduct(int id)
        {
            try
            {
                var deleteProduct = await _db.Products.FirstOrDefaultAsync(v => v.Id == id);
               _db.Products.Remove(deleteProduct);
               await _db.SaveChangesAsync();
                return deleteProduct;

            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _db.Products.SingleOrDefaultAsync(v => v.Id == id);
        }

        public async Task<ICollection<Product>> GetProducts()
        {
            return await _db.Products.ToListAsync();
        }

        public async Task<Product> UpdateProduct(int id, ProductRequestDTO product)
        {
            try
            {
                var updateProduct = await _db.Products.FirstOrDefaultAsync(v => v.Id == id);

                if (updateProduct == null)
                    return null;

               // updateProduct.Name = product.Name;
                updateProduct.Description = product.Description;
                updateProduct.CategoryId = product.CategoryId;
                updateProduct.CityId = product.CityId;
                updateProduct.PersonId = product.PersonId;
                updateProduct.PublishDate = product.PublishDate;
                updateProduct.EndedDate = product.EndedDate;
               await _db.SaveChangesAsync();
                return updateProduct;

            }
            catch (Exception)
            {

                return null;
            }

        }
    }
}
