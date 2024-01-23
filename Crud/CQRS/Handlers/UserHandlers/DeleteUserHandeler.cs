using Crud.CQRS.Commands.UserCommands;
using Crud.Data;
using Crud.Data.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Crud.CQRS.Handlers.UserHandlers
{
    public class DeleteUserHandeler : IRequestHandler<DeleteUserCommand, User>
    {
        private AppDbContext _db;

        public DeleteUserHandeler(AppDbContext db)
        {
            _db = db;
        }
        public async Task<User> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _db.Users.SingleOrDefaultAsync(x => x.Id == request.id);
            if (user != null)
            {
                _db.Users.Remove(user);
                await _db.SaveChangesAsync();
                return user;
            }

            return null;
        }
    }
}
