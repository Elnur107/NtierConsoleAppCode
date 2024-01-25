using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using NtierConsoleApp.Data.Repositories;
using NtierConsoleApp.Data.Entities;

namespace NtierConsoleApp.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DbContext dbContext;

        public CategoryRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(int categoryId)
        { 
            throw new NotImplementedException();
        }
    }
}
