using Crud.Data.Model;
using MediatR;

namespace Crud.CQRS.Queries.BlogQueries
{
    public record GetUserQuery : IRequest<List<User>>;
}
