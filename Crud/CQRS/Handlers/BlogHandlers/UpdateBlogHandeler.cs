using Crud.CQRS.Commands.BlogCommands;
using Crud.Data;
using Crud.Data.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Crud.CQRS.Handlers.BlogHandlers
{
    public class UpdateBlogHandeler : IRequestHandler<UpdateBlogCommand, Blog>
    {
        private AppDbContext _db;
        public UpdateBlogHandeler(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Blog> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var blog = await _db.Blogs.SingleOrDefaultAsync(x => x.Id == request.id);
            if (blog == null)
            {
                return null;
            }
            blog.Name = request.blog.Name;
            blog.Description = request.blog.Description;
            _db.SaveChanges();
            return blog;


        }
    }
}
