using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Core.Contracts
{
    public interface ISubCategoryRepository
    {
        Task<IEnumerable<SubCategory>> SubCategories();
        Task<SubCategory> GetSubCategoryById(int id);
        Task<SubCategory> AddSubCategory(SubCategoryRequestDTO SubCategoryRequestDTO);
        Task<SubCategory> UpdateSubCategory(int id, SubCategoryRequestDTO SubCategoryRequestDTO);
        Task<SubCategory> DeleteSubCategory(int id);
    }
}
