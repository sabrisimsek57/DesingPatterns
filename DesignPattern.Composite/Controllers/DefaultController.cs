using Microsoft.AspNetCore.Mvc;
using DesignPattern.Composite.Dal;
using DesignPattern.Composite.CompositePattern;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context context;

        public DefaultController(Context context)
        {
            this.context = context;
        }

       

        public IActionResult Index()
        {
            var categories = context.Categories.Include(x => x.Products).ToList();
            var values = Rekurisive(categories, new Category { CategoryName = "FirstCategory", CategoryID = 0 }, new ProductComposite(0, "FirstComposite"));
            ViewBag.v = values;
            return View();
        }

        public ProductComposite Rekurisive(List<Category> categories, Category firstCategory, ProductComposite firstComposite, ProductComposite leaf= null)
        {
            categories.Where(x => x.UpperCategoryID == firstCategory.CategoryID).ToList().ForEach(y =>
            {
            
            var productComposite = new ProductComposite(y.CategoryID, y.CategoryName);

            y.Products.ToList().ForEach(z =>
            {
                productComposite.Add(new ProductComponent(z.ProductID, z.ProductName));

            });
          
            if (leaf != null)
            {
                leaf.Add(productComposite);
            }
            else
            {
                firstComposite.Add(productComposite);
            }


                Rekurisive(categories, y, firstComposite, productComposite);
          });

          return firstComposite;

        }
    }
}



