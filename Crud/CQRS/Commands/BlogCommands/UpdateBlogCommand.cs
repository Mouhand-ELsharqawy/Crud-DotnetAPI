using Crud.Data.Model;
using MediatR;

namespace Crud.CQRS.Commands.BlogCommands
{
    public record UpdateBlogCommand(Blog blog, int id) : IRequest<Blog>;
}
