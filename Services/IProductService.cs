using week2task1.Models; // ✅ Ensure this namespace is correct
using System.Collections.Generic;

namespace week2task1.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product product); // ✅ Ensure this method is defined
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
