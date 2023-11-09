using MediatR;

namespace CqrsMediatrExample.Commands
{
    public record AddProductCommand(Product product) : IRequest<Product>;

}
