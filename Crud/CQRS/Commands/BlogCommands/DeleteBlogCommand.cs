using Crud.Data.Model;
using MediatR;

namespace Crud.CQRS.Commands.BlogCommands
{
    public record DeleteBlogCommand(int id) : IRequest<Blog>; 
}
