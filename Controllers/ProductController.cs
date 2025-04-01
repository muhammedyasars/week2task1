using Microsoft.AspNetCore.Mvc;
using week2task1.Models; // ✅ Import the correct namespace
using week2task1.Services;

namespace week2task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            List<Product> products = _productService.GetAllProducts(); // ✅ Ensure "Product" is recognized
            return Ok(products);
        }
    }
}
