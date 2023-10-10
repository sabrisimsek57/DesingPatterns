using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class RemoveProductCommandHandler
    {

        private readonly Context context;

        public RemoveProductCommandHandler(Context context)
        {
            this.context = context;
        }

        public void Handle(RemoveProductCommand command)
        {
            var values = context.Products.Find(command.Id);
            context.Products.Remove(values);
            context.SaveChanges();
        }
    }
}
