using System;
using NtierConsoleApp.Business.Services;
using NtierConsoleApp.Data;
using NtierConsoleApp.Data.Repositories;

namespace NtierConsoleApp.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=VENUS08;Database=Northwind;Trusted_Connection=True;";

            var dbContext = new DbContext(connectionString);

            var productRepository = new ProductRepository(dbContext);
            var productService = new ProductService(productRepository);

            Console.WriteLine("All Products:");
            var allProducts = productService.GetAllProducts();
            foreach (var product in allProducts)
            {
                Console.WriteLine($"{product.ProductId} - {product.ProductName}");
            }

            Console.ReadLine();
        }
    }
}
