using Microsoft.AspNetCore.Mvc;
using DesignPattern.Face.Dal;
namespace DesignPattern.Face.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        [HttpGet]
        public IActionResult AddNewProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewProduct(Product product)
        {
            context.products.Add(product);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        public IActionResult ProductList()
        {
            var values = context.products.ToList();
            return View(values);
        }

    }
}
