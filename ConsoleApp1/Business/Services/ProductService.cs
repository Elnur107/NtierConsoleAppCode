using System.Collections.Generic;
using NtierConsoleApp.Data.Repositories;
using NtierConsoleApp.Business.Interfaces;
using NtierConsoleApp.Data.Entities;
using NtierConsoleApp.Data.Repositories;

namespace NtierConsoleApp.Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public List<Product> GetAllProducts()
        {
            return productRepository.GetAllProducts();
        }

        public Product GetProductById(int productId)
        {
            return productRepository.GetProductById(productId);
        }

        public void AddProduct(Product product)
        {
            productRepository.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            productRepository.UpdateProduct(product);
        }

        public void DeleteProduct(int productId)
        {
            productRepository.DeleteProduct(productId);
        }
    }
}
