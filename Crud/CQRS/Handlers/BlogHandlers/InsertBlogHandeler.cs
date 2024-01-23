using Crud.CQRS.Commands.BlogCommands;
using Crud.Data;
using Crud.Data.Model;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Crud.CQRS.Handlers.BlogHandlers
{
    public class InsertBlogHandeler : IRequestHandler<InsertBlogCommand, Blog>
    {
        private AppDbContext _db;
        public InsertBlogHandeler(AppDbContext db)
        {
            _db = db;            
        }

        public async Task<Blog> Handle(InsertBlogCommand request, CancellationToken cancellationToken)
        {
            var user = await _db.Users.SingleOrDefaultAsync(x => x.Id == request.blog.UserId);
            if(user == null)
            {
                return null;
            }

            await _db.Blogs.AddAsync(request.blog);
            _db.SaveChanges();
            return await Task.FromResult(request.blog);
        }
    }
}
