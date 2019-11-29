using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> Categories();
        Task<Category> GetCategoryById(int id);
        Task<Category> AddCategory(CategoryRequestDTO category);
        Task<Category> UpdateCategory(int id, CategoryRequestDTO category);
        Task<Category> DeleteCategory(int id);

    }
}
