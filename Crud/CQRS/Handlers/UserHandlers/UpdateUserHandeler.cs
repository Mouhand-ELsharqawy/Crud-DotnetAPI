using Crud.CQRS.Commands.UserCommands;
using Crud.Data;
using Crud.Data.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Crud.CQRS.Handlers.UserHandlers
{
    public class UpdateUserHandeler : IRequestHandler<UpdateUserCommand, User>
    {
        private AppDbContext _db;

        public UpdateUserHandeler(AppDbContext db)
        {
            _db = db;
        }

        public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _db.Users.SingleOrDefaultAsync(x => x.Id == request.id);
            if (user == null)
            {
                return null;
            }
           user.FirstName = request.user.FirstName;
           user.MiddleName = request.user.MiddleName;
           user.LastName = request.user.LastName;
           user.Email = request.user.Email;
           user.PhoneNumber = request.user.PhoneNumber;
            _db.SaveChanges();
            return user;

        }
    }
}
