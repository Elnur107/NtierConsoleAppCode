# NtierConsoleApp

This console application implements CRUD operations for Product and Category entities using N-tier architecture and ADO.NET.

## Installation

1. Clone this project to your local machine.
2. Open the `NtierConsoleApp.sln` file with Visual Studio.
3. Open the `appsettings.json` file and set the connection string for the database.
4. Navigate to the `Program.cs` file and modify it to include the necessary operations:

    ```csharp
    // Example of ProductService usage
    var productService = new ProductService(new ProductRepository(new DbContext("your_connection_string_here")));

    // Retrieve all products
    var allProducts = productService.GetAllProducts();
    foreach (var product in allProducts)
    {
        Console.WriteLine($"{product.ProductId} - {product.ProductName} - {product.Price:C}");
    }

    // Add a new product
    // productService.AddProduct(new Product { ProductName = "New Product", CategoryId = 1, Price = 50.00 });
    ```

## Usage

In this project, use `ProductService` and `CategoryService` classes to perform CRUD operations.

Example:

```csharp
// Example of using ProductService
var productService = new ProductService(new ProductRepository(new DbContext("your_connection_string_here")));

// Retrieve all products
var allProducts = productService.GetAllProducts();
foreach (var product in allProducts)
{
    Console.WriteLine($"{product.ProductId} - {product.ProductName} - {product.Price:C}");
}

// Add a new product
// productService.AddProduct(new Product { ProductName = "New Product", CategoryId = 1, Price = 50.00 });




Certainly! Below is a sample README.md file for a console application implementing CRUD operations for Product and Category entities using N-tier architecture and ADO.NET:

markdown
Copy code
# NtierConsoleApp

This console application implements CRUD operations for Product and Category entities using N-tier architecture and ADO.NET.

## Installation

1. Clone this project to your local machine.
2. Open the `NtierConsoleApp.sln` file with Visual Studio.
3. Open the `appsettings.json` file and set the connection string for the database.
4. Navigate to the `Program.cs` file and modify it to include the necessary operations:

    ```csharp
    // Example of ProductService usage
    var productService = new ProductService(new ProductRepository(new DbContext("your_connection_string_here")));

    // Retrieve all products
    var allProducts = productService.GetAllProducts();
    foreach (var product in allProducts)
    {
        Console.WriteLine($"{product.ProductId} - {product.ProductName} - {product.Price:C}");
    }

    // Add a new product
    // productService.AddProduct(new Product { ProductName = "New Product", CategoryId = 1, Price = 50.00 });
    ```

## Usage

In this project, use `ProductService` and `CategoryService` classes to perform CRUD operations.

Example:

```csharp
// Example of using ProductService
var productService = new ProductService(new ProductRepository(new DbContext("your_connection_string_here")));

// Retrieve all products
var allProducts = productService.GetAllProducts();
foreach (var product in allProducts)
{
    Console.WriteLine($"{product.ProductId} - {product.ProductName} - {product.Price:C}");
}

// Add a new product
// productService.AddProduct(new Product { ProductName = "New Product", CategoryId = 1, Price = 50.00 });

Contribution and Support
If you have questions, suggestions, or contributions regarding this project, please feel free to reach out.


Feel free to modify and expand this template according to the specific features and requirements of your project.
