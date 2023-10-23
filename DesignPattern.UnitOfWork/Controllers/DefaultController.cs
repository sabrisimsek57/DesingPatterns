using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.EntityLayer.Concrete;
using DesignPattern.UnitOfWork.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesignPattern.UnitOfWork.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerService customerService;

        public DefaultController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerViewModel model)
        {
            var value1 = customerService.TGetByID(model.SenderID);
            var value2 = customerService.TGetByID(model.ReciverID);

            value1.CustomerBalance -= model.Amount;
            value2.CustomerBalance += model.Amount;

            List<Customer> modifedCustomers = new List<Customer>()
            {
                value1,
                value2
            };
            customerService.TMultiUpdate(modifedCustomers);
            return View();
        }
    }
}
