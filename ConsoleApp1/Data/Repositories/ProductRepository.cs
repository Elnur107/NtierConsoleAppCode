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
            using (SqlConnection connection = dbContext.GetConnection())
            {
                connection.Open();

                string query = "SELECT ProductId, ProductName, CategoryId, Price FROM Products WHERE ProductId = @ProductId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", productId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Product
                            {
                                ProductId = Convert.ToInt32(reader["ProductId"]),
                                ProductName = reader["ProductName"].ToString(),
                                CategoryId = Convert.ToInt32(reader["CategoryId"]),
                                Price = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : 0m
                            };
                        }
                    }
                }

                return null;
            }
        }

        public void AddProduct(Product newProduct)
        {
            using (SqlConnection connection = dbContext.GetConnection())
            {
                connection.Open();

                string query = "INSERT INTO Products (ProductName, CategoryId, Price) VALUES (@ProductName, @CategoryId, @Price)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", newProduct.ProductName);
                    command.Parameters.AddWithValue("@CategoryId", newProduct.CategoryId);
                    command.Parameters.AddWithValue("@Price", newProduct.Price);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(Product updatedProduct)
        {
            using (SqlConnection connection = dbContext.GetConnection())
            {
                connection.Open();

                string query = "UPDATE Products SET ProductName = @ProductName, CategoryId = @CategoryId, Price = @Price WHERE ProductId = @ProductId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", updatedProduct.ProductId);
                    command.Parameters.AddWithValue("@ProductName", updatedProduct.ProductName);
                    command.Parameters.AddWithValue("@CategoryId", updatedProduct.CategoryId);
                    command.Parameters.AddWithValue("@Price", updatedProduct.Price);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(int productId)
        {
            using (SqlConnection connection = dbContext.GetConnection())
            {
                connection.Open();

                string query = "DELETE FROM Products WHERE ProductId = @ProductId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", productId);

                    command.ExecuteNonQuery();
                }
            }
        }

    }


}
