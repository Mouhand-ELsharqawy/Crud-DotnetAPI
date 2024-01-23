using Crud.CQRS.Commands.UserCommands;
using Crud.CQRS.Queries.BlogQueries;
using Crud.Data.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var res = await _mediator.Send(new GetUserQuery());
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> InsertUser(User user)
        {
            var res = await _mediator.Send(new InsertUserCommand(user));
            return Ok(res);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOneUser(int id)
        {
            var res = await _mediator.Send(new GetOneUserQuery(id));    
            return Ok(res);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateResult(User user, int id)
        {
            var res = await _mediator.Send(new UpdateUserCommand(user, id));
            return Ok(res);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var res = await _mediator.Send(new DeleteUserCommand(id));
            return Ok(res);
        }

    }
}
