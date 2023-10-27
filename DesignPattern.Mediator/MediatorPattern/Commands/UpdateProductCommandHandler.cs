using DesignPattern.Mediator.Dal;
using DesignPattern.Mediator.MediatorPattern.Handlers;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Commands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private Context context;

        public UpdateProductCommandHandler(Context context)
        {
            this.context = context;
        }

        public async  Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = context.Products.Find(request.ProductID); 
            values.ProductName = request.ProductName;
            values.ProductPrice = request.ProductPrice;
            values.ProductStock = request.ProductStock;
            values.ProductCategory = request.ProductCategory;
            values.ProductStock = request.ProductStock;
            values.ProductStockType = request.ProductStockType;
            await context.SaveChangesAsync();
        }
    }
}
