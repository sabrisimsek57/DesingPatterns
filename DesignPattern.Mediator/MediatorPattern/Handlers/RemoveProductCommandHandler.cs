using DesignPattern.Mediator.MediatorPattern.Commands;
using MediatR;
using DesignPattern.Mediator.Dal;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly Context context;

        public RemoveProductCommandHandler(Context context)
        {
            this.context = context;
        }

        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var values = context.Products.Find(request.Id);
            context.Products.Remove(values);
            await context.SaveChangesAsync();
        }
    }
}
