using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.InputModels;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using DevFreela.Application.Commands.CreateProject;
using System.Threading.Tasks;
using DevFreela.Application.Commands.CreateProjectComment;
using DevFreela.Application.Commands.DeleteProject;
using DevFreela.Application.Commands.StartProject;
using DevFreela.Application.Commands.UpdateProject;
using DevFreela.Application.Commands.FinishProject;
using DevFreela.Application.Queries.GetAllProjects;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly IMediator _mediator;
        public ProjectsController(IProjectService projectService, IMediator mediator)
        {
            _projectService = projectService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {
            var getAllProjectsQuery = new GetAllProjectsQuery(query);            
            var projects = await _mediator.Send(getAllProjectsQuery);

            return Ok(projects);
        }

        /* Dúvida
         * Esse é um parâmetro único, 
         * como ficaria a passagem para consulta com mais de um parâmetro? 
         * Ainda não verifiquei como.
         */

        //api/projects/1 << o número é o parâmetro recebido pelo método IActionResult >>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Buscar o projeto.
            var project = _projectService.GetById(id);

            if(project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        /* Notação FromBody
         * Que quer dizer corpo da requisição
         */
        [HttpPost]
        public async Task<IActionResult>  Post([FromBody] CreateProjectCommand command)
        {
            if (command.Title.Length > 50)
                return BadRequest();

            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        // api/projects/2  << o número é o parâmetro recebido pelo método IActionResult >>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateProjectCommand command)
        {
            if (command.Description.Length > 200)
                return BadRequest();

            await _mediator.Send(command);
            
            return NoContent();
        }

        // api/projects/3
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteProjectCommand(id);
            await _mediator.Send(command);
                
            return NoContent();
        }

        // api/projects/1/comments POST
        [HttpPost("{id}/comments")]
        public async Task<IActionResult> PostComment(int id, [FromBody] CreateCommentCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
        
        // api/projects/1/start
        [HttpPut("{id}/start")]
        public async Task<IActionResult> Start(int id)
        {
            var command = new StartProjectCommand(id);
            await _mediator.Send(command);

            return NoContent();
        }

        // api/projects/1/finish
        [HttpPut("{id}/finish")]
        public async Task<IActionResult> Finish(int id)
        {
            var command = new FinishProjectCommand(id);
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
