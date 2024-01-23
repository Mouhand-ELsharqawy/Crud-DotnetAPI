using Crud.CQRS.Commands.BlogCommands;
using Crud.CQRS.Handlers.BlogHandlers;
using Crud.CQRS.Queries.BlogQueries;
using Crud.Data.dto;
using Crud.Data.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetBlog()
        {
            var res = await _mediator.Send(new GetBlogsQuery());
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> AddBlog(Blog blog)
        {
            var res = await _mediator.Send(new InsertBlogCommand(blog));
            return Ok(res);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOneBlog(int id)
        {
            var res = await _mediator.Send(new GetOneBlogQuery(id));
            return Ok(res);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBlog(Blog blog, int id)
        {
            var res = await _mediator.Send(new UpdateBlogCommand(blog,id));
            return Ok(res);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var res = await _mediator.Send(new  DeleteBlogCommand(id));
            return Ok(res); 
        }
        
    }
}
