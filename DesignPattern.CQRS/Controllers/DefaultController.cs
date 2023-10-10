using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.CQRSPattern.Handlers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler getProductQueryHandler;
        private readonly GetProductByIDQueryHandler getProductByIDQueryHandler;
        private readonly CreateProductCommandHandler createProductCommandHandler;
        private readonly RemoveProductCommandHandler removeProductCommandHandler;
        private readonly GetProductUpdateByIDQueryHandler getProductUpdateByIDQueryHandler;
        private readonly UpdateProductCommandHandler updateProductCommandHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler, GetProductByIDQueryHandler getProductByIDQueryHandler, CreateProductCommandHandler createProductCommandHandler, RemoveProductCommandHandler removeProductCommandHandler, GetProductUpdateByIDQueryHandler getProductUpdateByIDQueryHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            this.getProductQueryHandler = getProductQueryHandler;
            this.getProductByIDQueryHandler = getProductByIDQueryHandler;
            this.createProductCommandHandler = createProductCommandHandler;
            this.removeProductCommandHandler = removeProductCommandHandler;
            this.getProductUpdateByIDQueryHandler = getProductUpdateByIDQueryHandler;
            this.updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = getProductQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult GetProduct(int id)
        {
            var values = getProductByIDQueryHandler.Handle(new CQRSPattern.Queries.GetProductByIDQuery(id));

            return View(values);
        }
      
        public IActionResult RemoveProduct(int id)
        {
            removeProductCommandHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = getProductUpdateByIDQueryHandler.Handle(new CQRSPattern.Queries.GetProductUpdateByIDQuery(id));

            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            updateProductCommandHandler.Handler(command);
            return RedirectToAction("Index");
        }

    }
}
