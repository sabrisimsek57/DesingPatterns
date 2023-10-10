using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context context;

        public UpdateProductCommandHandler(Context context)
        {
            this.context = context;
        }

        public void Handler(UpdateProductCommand command)
        {
            var values = context.Products.Find(command.ProductID);
            values.Name = command.Name;
            values.Price = command.Price;
            values.Stock= command.Stock;
            values.Description = command.Description;
            values.Status = true;
            context.SaveChanges();
            
        }
    }
}
