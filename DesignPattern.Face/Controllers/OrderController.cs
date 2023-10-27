using DesignPattern.Face.Dal;
using DesignPattern.Face.FacePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Face.Controllers
{
    public class OrderController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult OrderDetailStart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrderDetailStart(int customerID, int productId,int orderID, int productCount, decimal productPrice)
        {
            OrderFacade order = new OrderFacade();
            order.CompleteOrderDeatil(customerID, productId, orderID, productPrice, productCount);
            return  RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult OrderStart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrderStart(int customerID)
        {
          OrderFacade orderFacade = new OrderFacade();
            orderFacade.CompleteOrder(customerID);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
