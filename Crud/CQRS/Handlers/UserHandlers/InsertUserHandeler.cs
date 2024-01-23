using Crud.CQRS.Commands.UserCommands;
using Crud.Data;
using Crud.Data.Model;
using MediatR;

namespace Crud.CQRS.Handlers.UserHandlers
{
    public class InsertUserHandeler : IRequestHandler<InsertUserCommand, User>
    {
        private AppDbContext _db;

        public InsertUserHandeler(AppDbContext db)
        {
            _db = db;
        }

        public async Task<User> Handle(InsertUserCommand request, CancellationToken cancellationToken)
        {
            await _db.Users.AddAsync(request.user);
            _db.SaveChanges();
            return await Task.FromResult(request.user);
        }
    }
}
