using System;
using NtierConsoleApp.Business.Services;
using NtierConsoleApp.Data;
using NtierConsoleApp.Data.Entities;
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

            var categoryRepository = new CategoryRepository(dbContext);
            var categoryService = new CategoryService(categoryRepository);


            productService.AddProduct(new Product { ProductName = "New Product", CategoryId = 1, Price = 50 });

            Console.WriteLine("All Products:");
            var allProducts = productService.GetAllProducts();
            foreach (var product in allProducts)
            {
                Console.WriteLine($"{product.ProductId} - {product.ProductName} - {product.Price:C}");
            }

            Console.WriteLine("\nSpecific Product (ID=1):");
            var productById = productService.GetProductById(1);
            if (productById != null)
            {
                Console.WriteLine($"{productById.ProductId} - {productById.ProductName} - {productById.Price:C}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }

            productService.UpdateProduct(new Product { ProductId = 1, ProductName = "Updated Product", CategoryId = 2, Price = 75 });

            Console.WriteLine("\nUpdated Product (ID=1):");
            var updatedProduct = productService.GetProductById(1);
            if (updatedProduct != null)
            {
                Console.WriteLine($"{updatedProduct.ProductId} - {updatedProduct.ProductName} - {updatedProduct.Price:C}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }

            productService.DeleteProduct(1);

            Console.WriteLine("\nDeleted Product (ID=1):");
            var deletedProduct = productService.GetProductById(1);
            if (deletedProduct != null)
            {
                Console.WriteLine($"{deletedProduct.ProductId} - {deletedProduct.ProductName} - {deletedProduct.Price:C}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }

            Console.ReadLine();
        }
    }
}
