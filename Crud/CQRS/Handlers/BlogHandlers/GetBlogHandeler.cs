using Crud.CQRS.Queries.BlogQueries;
using Crud.Data;
using Crud.Data.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Crud.CQRS.Handlers.BlogHandlers
{
    public class GetBlogHandeler : IRequestHandler<GetBlogsQuery, List<Blog>>
    {
        AppDbContext _db;
        public GetBlogHandeler(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<Blog>> Handle(GetBlogsQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult( _db.Blogs.ToList());
        }
    }
}
