using Crud.Data.Model;
using MediatR;

namespace Crud.CQRS.Queries.BlogQueries
{
    public record GetOneUserQuery(int id) : IRequest<User>;
}
