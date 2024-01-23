using Crud.Data.Model;
using MediatR;

namespace Crud.CQRS.Commands.BlogCommands
{
    public record InsertBlogCommand(Blog blog) : IRequest<Blog>;
}
