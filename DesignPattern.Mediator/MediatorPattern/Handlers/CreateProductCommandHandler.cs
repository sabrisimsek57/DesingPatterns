using DesignPattern.Mediator.MediatorPattern.Commands;
using MediatR;
using DesignPattern.Mediator.Dal;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context context;

        public CreateProductCommandHandler(Context context)
        {
            this.context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            context.Products.Add(new Product
            {
                ProductName = request.ProductName,
                ProductCategory = request.ProductCategory,
                ProductPrice = request.ProductPrice,
                ProductStock = request.ProductStock,
                ProductStockType = request.ProductStockType
            });
            await context.SaveChangesAsync();
        }
    }
}
