using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context context;

        public CreateProductCommandHandler(Context context)
        {
            this.context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            context.Products.Add(new Product
            {
                Description = command.Description,
                Name = command.Name,
                Price = command.Price,
                Stock = command.Stock,
                Status = true
            });
            context.SaveChanges();
        }
    }
}
