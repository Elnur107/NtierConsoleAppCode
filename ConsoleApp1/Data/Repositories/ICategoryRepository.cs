using System.Collections.Generic;
using NtierConsoleApp.Data.Entities;

namespace NtierConsoleApp.Data.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int categoryId);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int categoryId);
    }
}
