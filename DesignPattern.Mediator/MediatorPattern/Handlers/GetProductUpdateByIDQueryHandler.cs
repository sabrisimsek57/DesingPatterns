using DesignPattern.Mediator.MediatorPattern.Queries;
using DesignPattern.Mediator.MediatorPattern.Results;
using DesignPattern.Mediator.Dal;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler : IRequestHandler<GetProductUpdateByIDQuery, UpdateProductQueryResult>
    {
        private readonly Context context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            this.context = context;
        }

        public async Task<UpdateProductQueryResult> Handle(GetProductUpdateByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await context.Products.FindAsync(request.Id);
            return new UpdateProductQueryResult
            {
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                ProductCategory = values.ProductCategory,
                ProductPrice = values.ProductPrice,
                ProductStock = values.ProductStock,
                ProductStockType = values.ProductStockType
            };
        }
    }
}
