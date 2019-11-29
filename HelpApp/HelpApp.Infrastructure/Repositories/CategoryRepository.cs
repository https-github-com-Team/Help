using HelpApp.Core.Contracts;
using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using HelpApp.Infrastructure.Db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Infrastructure.Repositories
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly HelpDbContext _db;

        public CategoryRepository(HelpDbContext db)
        {
            _db = db;
        }

        public async Task<Category> AddCategory(CategoryRequestDTO category)
        {
            try
            {
                Category newCategory = new Category()
                {
                    Name = category.Name
                };
               _db.Categories.Add(newCategory);
               await _db.SaveChangesAsync();
                return newCategory;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<IEnumerable<Category>> Categories()
        {
            return await _db.Categories.ToListAsync();
        }

        public async Task<Category> DeleteCategory(int id)
        {
            var deleteCategory = await _db.Categories.FirstOrDefaultAsync(v => v.Id == id);
            _db.Categories.Remove(deleteCategory);
           await _db.SaveChangesAsync();
            return deleteCategory;
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _db.Categories.SingleOrDefaultAsync(v => v.Id == id);
        }

        public async Task<Category> UpdateCategory(int id, CategoryRequestDTO category)
        {
            try
            {
                var updateCategory = await _db.Categories.FirstOrDefaultAsync(v => v.Id == id);
                if (updateCategory == null)
                    return null;
                updateCategory.Name = category.Name;
               await _db.SaveChangesAsync();
                return updateCategory;
            }
            catch (Exception)
            {

                return null;
            }
        }

        
    }
}
