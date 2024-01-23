using Crud.CQRS.Queries.BlogQueries;
using Crud.Data;
using Crud.Data.Model;
using MediatR;

namespace Crud.CQRS.Handlers.UserHandlers
{
    public class GetUserHandeler : IRequestHandler<GetUserQuery, List<User>>
    {
        private AppDbContext _db;

        public GetUserHandeler(AppDbContext db)
        {
            _db = db;
        }
        public async Task<List<User>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_db.Users.ToList());
        }
    }
}
