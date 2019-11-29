using HelpApp.Core.Contracts;
using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Core.Services
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly IUnitOfWork unitOfWork;

        public SubCategoryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<SubCategory> AddSubCategory(SubCategoryRequestDTO SubCategoryRequestDTO)
        {
            return await unitOfWork.SubCategoryRepository.AddSubCategory(SubCategoryRequestDTO);
        }

        public async Task<SubCategory> DeleteSubCategory(int id)
        {
            return await unitOfWork.SubCategoryRepository.DeleteSubCategory(id);
        }

        public async Task<SubCategory> GetSubCategoryById(int id)
        {
            return await unitOfWork.SubCategoryRepository.GetSubCategoryById(id);
        }

        public async Task<IEnumerable<SubCategory>> SubCategories()
        {
            return await unitOfWork.SubCategoryRepository.SubCategories();
        }

        public async Task<SubCategory> UpdateSubCategory(int id, SubCategoryRequestDTO SubCategoryRequestDTO)
        {
            return await unitOfWork.SubCategoryRepository.UpdateSubCategory(id, SubCategoryRequestDTO);
        }
    }
}
