using System.Collections.Generic;
using NtierConsoleApp.Business.Interfaces;
using NtierConsoleApp.Data.Entities;
using NtierConsoleApp.Data.Repositories;

namespace NtierConsoleApp.Business.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public List<Category> GetAllCategories()
        {
            return categoryRepository.GetAllCategories();
        }

        public Category GetCategoryById(int categoryId)
        {
            return categoryRepository.GetCategoryById(categoryId);
        }

        public void AddCategory(Category category)
        {
            categoryRepository.AddCategory(category);
        }

        public void UpdateCategory(Category category)
        {
            categoryRepository.UpdateCategory(category);
        }

        public void DeleteCategory(int categoryId)
        {
            categoryRepository.DeleteCategory(categoryId);
        }
    }
}
