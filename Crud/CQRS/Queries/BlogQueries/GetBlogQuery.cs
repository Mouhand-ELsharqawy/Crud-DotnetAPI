using Crud.Data.Model;
using MediatR;

namespace Crud.CQRS.Queries.BlogQueries
{
    public record GetBlogsQuery : IRequest<List<Blog>>;
}
