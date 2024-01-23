using Crud.Data.Model;
using MediatR;

namespace Crud.CQRS.Commands.UserCommands
{
    public record DeleteUserCommand(int id) : IRequest<User>;
}
