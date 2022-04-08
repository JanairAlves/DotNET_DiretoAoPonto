using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        /* Entendimento de funcionamento até o momento.
         * Esse Get pode retornar uma lista filtrada pelo query string OU
         * removo o parâmetro "string query" do método e ele retorna tudo OU
         * por padrão retorna OK caso não encontre nada.
         */

        // api/projects?query=net core << a parte 'net core' é um exemplo da informação que vai  na URL. >>
        [HttpGet]
        public IActionResult Get(string query)
        {
            var projects = _projectService.GetAll(query);
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
        public IActionResult Post([FromBody] NewProjectInputModel inputModel)
        {
            if (inputModel.Title.Length > 50)
            {
                return BadRequest();
            }

            /* Parâmetros do CreateAtAction
             * Nome da API que vai obter os detalhes dele, nesse caso seria ("GetById") que é o método acima.
             * nameof(GetByAction)....
             */

            var id = _projectService.Create(inputModel);

            //Cadastrar o projeto.
            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        // api/projects/2  << o número é o parâmetro recebido pelo método IActionResult >>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectInputModel inputModel)
        {
            if (inputModel.Description.Length > 200)
            {
                return BadRequest();
            }

            _projectService.Update(inputModel);

            // Atualizo o objeto.
            return NoContent();
        }

        // api/projects/3
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _projectService.Delete(id);

            // Remover
            return NoContent();
        }

        // api/projects/1/comments POST
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateCommentInputModel inputModel)
        {
            _projectService.CreateComment(inputModel);

            return NoContent();
        }
        
        // api/projects/1/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            _projectService.Start(id);

            return NoContent();
        }

        // api/projects/1/finish
        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            _projectService.Finish(id);

            return NoContent();
        }

    }
}
