using Crud.Data.Model;
using MediatR;

namespace Crud.CQRS.Queries.BlogQueries
{
    public record GetOneBlogQuery(int id) : IRequest<Blog>;
}
