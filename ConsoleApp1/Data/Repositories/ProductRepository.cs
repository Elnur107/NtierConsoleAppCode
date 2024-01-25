using NtierConsoleApp.Data.Repositories;
using NtierConsoleApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NtierConsoleApp.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbContext dbContext;

        public ProductRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = dbContext.GetConnection())
            {
                connection.Open();

                string query = "SELECT ProductId, ProductName, CategoryId, Price FROM Products";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                ProductId = Convert.ToInt32(reader["ProductId"]),
                                ProductName = reader["ProductName"].ToString(),
                                CategoryId = Convert.ToInt32(reader["CategoryId"]),
                                Price = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : 0m
                            };

                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }


        public Product GetProductById(int productId)
        {

            throw new NotImplementedException();
        }

        public void AddProduct(Product product)
        {

            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {

            throw new NotImplementedException();
        }

        public void DeleteProduct(int productId)
        {

            throw new NotImplementedException();
        }

    }


}
