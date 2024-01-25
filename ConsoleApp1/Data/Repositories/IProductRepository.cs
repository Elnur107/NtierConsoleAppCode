using NtierConsoleApp.Data.Entities;
using System.Collections.Generic;

namespace NtierConsoleApp.Data.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int productId);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
    }
}
