using Crud.Data.dto;
using Crud.Data.Model;
using MediatR;

namespace Crud.CQRS.Commands.UserCommands
{
    public record InsertUserCommand(User user) : IRequest<User>;
}
