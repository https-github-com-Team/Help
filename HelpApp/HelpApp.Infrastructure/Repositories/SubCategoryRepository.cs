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
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly HelpDbContext _db;
        public SubCategoryRepository(HelpDbContext db)
        {
            _db = db;
        }
        public async Task<SubCategory> AddSubCategory(SubCategoryRequestDTO SubCategoryRequestDTO)
        {
            try
            {
                SubCategory subCategory = new SubCategory()
                {
                    Name = SubCategoryRequestDTO.Name,
                    CategoryId = SubCategoryRequestDTO.CategoryId
                };
                _db.SubCategories.Add(subCategory);
                await _db.SaveChangesAsync();
                return subCategory;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<SubCategory> DeleteSubCategory(int id)
        {
            var deleteSubCategory = await _db.SubCategories.FirstOrDefaultAsync(v => v.Id == id);
            if (deleteSubCategory == null)
                return null;
            _db.SubCategories.Remove(deleteSubCategory);
            await _db.SaveChangesAsync();

            return deleteSubCategory;
        }

        public async Task<SubCategory> GetSubCategoryById(int id)
        {
            var subCategoryGetByID = await _db.SubCategories.FirstOrDefaultAsync(v => v.Id == id);
            if (subCategoryGetByID == null)
                return null;
            return subCategoryGetByID;
        }

        public async Task<IEnumerable<SubCategory>> SubCategories()
        {
            return await _db.SubCategories.ToListAsync();
        }

        public async Task<SubCategory> UpdateSubCategory(int id, SubCategoryRequestDTO SubCategoryRequestDTO)
        {
            try
            {
                var updateSubCategory = await _db.SubCategories.FirstOrDefaultAsync(v => v.Id == id);
                if (updateSubCategory == null)
                    return null;
                updateSubCategory.Name = SubCategoryRequestDTO.Name;
                updateSubCategory.CategoryId = SubCategoryRequestDTO.CategoryId;
                await _db.SaveChangesAsync();
                return updateSubCategory;
            }
            catch (Exception)
            {

                return null;
            }

                  
        }
    }
}
