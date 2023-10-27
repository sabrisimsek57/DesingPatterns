using DesignPattern.Mediator.Dal;
using DesignPattern.Mediator.MediatorPattern.Queries;
using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
    {
        private readonly Context context;

        public GetAllProductQueryHandler(Context context)
        {
            this.context = context;
        }

        public async Task<List<GetAllProductQueryResult>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await context.Products.Select(x => new GetAllProductQueryResult
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                ProductCategory = x.ProductCategory,
                ProductPrice = x.ProductPrice,
                ProductStock = x.ProductStock,
                ProductStockType = x.ProductStockType



            }).ToListAsync();

        }
    }
}
