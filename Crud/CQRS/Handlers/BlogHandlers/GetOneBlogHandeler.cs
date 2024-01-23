using Crud.CQRS.Queries.BlogQueries;
using Crud.Data;
using Crud.Data.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Crud.CQRS.Handlers.BlogHandlers
{
    public class GetOneBlogHandeler : IRequestHandler<GetOneBlogQuery, Blog>
    {
        AppDbContext _db;

        public GetOneBlogHandeler(AppDbContext db)
        {
            _db = db;
        }

      

        public async Task<Blog> Handle(GetOneBlogQuery request, CancellationToken cancellationToken)
        {
            var blog = await _db.Blogs.SingleOrDefaultAsync(x => x.Id == request.id);
            return await Task.FromResult(blog);
        }
    }
}
