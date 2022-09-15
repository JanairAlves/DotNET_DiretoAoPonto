using DevFreela.API.Models;
using DevFreela.Application.Commands.CreateUser;
using DevFreela.Application.Commands.DeleteUser;
using DevFreela.Application.Commands.UpdateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // api/users/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // api/users
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserCommand command)
        {
            if (command.FullName.Length > 50)
                return BadRequest();

            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPut("{id}/update")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateUserCommand command)
        {
            if (command.FullName.Length > 50)
                return BadRequest();
            
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteUserCommand(id);
            await _mediator.Send(command);

            return NoContent();
        }

        // api/users/1/login
        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginModel login)
        {
            return NoContent();
        }
    }
}
