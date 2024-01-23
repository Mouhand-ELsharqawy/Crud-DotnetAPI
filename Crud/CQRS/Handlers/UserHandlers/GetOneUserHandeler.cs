using Crud.CQRS.Queries.BlogQueries;
using Crud.Data;
using Crud.Data.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Crud.CQRS.Handlers.UserHandlers
{
    public class GetOneUserHandeler : IRequestHandler<GetOneUserQuery, User>
    {
        private AppDbContext _db;

        public GetOneUserHandeler(AppDbContext db)
        {
            _db = db;
        }
        public async Task<User> Handle(GetOneUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _db.Users.SingleOrDefaultAsync(x => x.Id == request.id);
            return await Task.FromResult(user);
        }
    }
}
