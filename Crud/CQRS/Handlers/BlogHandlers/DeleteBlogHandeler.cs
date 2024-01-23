using Crud.CQRS.Commands.BlogCommands;
using Crud.Data;
using Crud.Data.Model;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Crud.CQRS.Handlers.BlogHandlers
{
    public class DeleteBlogHandeler : IRequestHandler<DeleteBlogCommand,Blog>
    {
        AppDbContext _db;
        public DeleteBlogHandeler(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Blog> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            var blog = await _db.Blogs.SingleOrDefaultAsync(x => x.Id == request.id);
            if (blog != null)
            {
                _db.Blogs.Remove(blog);
                await _db.SaveChangesAsync();
                return blog;
            }

            return null;
        }
    }
}
