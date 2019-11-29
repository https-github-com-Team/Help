using HelpApp.Core.Contracts;
using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Core.Services
{
    public class CategoryService:ICategoryService
    {
        private readonly IUnitOfWork unitOfWork;
        public CategoryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Category> AddCategory(CategoryRequestDTO category)
        {
            return await unitOfWork.CategoryRepository.AddCategory(category);
        }

        public async Task<IEnumerable<Category>> Categories()
        {
            return await unitOfWork.CategoryRepository.Categories();
        }

        public async Task<Category> DeleteCategory(int id)
        {
            return await unitOfWork.CategoryRepository.DeleteCategory(id);
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await unitOfWork.CategoryRepository.GetCategoryById(id);
        }

        public async Task<Category> UpdateCategory(int id, CategoryRequestDTO category)
        {
            return await unitOfWork.CategoryRepository.UpdateCategory(id, category);
        }
    }
}
