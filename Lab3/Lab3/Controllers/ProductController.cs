using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details()
        {
            // Tạo một sản phẩm mẫu
            var product = new Product
            {
                Id = 1,
                Name = "Sản phẩm A",
                Price = 99.99M
            };

            return View(product); 
        }
    }
}
