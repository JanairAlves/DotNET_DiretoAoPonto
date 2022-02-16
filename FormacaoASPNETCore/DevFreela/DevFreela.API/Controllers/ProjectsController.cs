using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly OpeningTimeOption _option;
        public ProjectsController(IOptions<OpeningTimeOption> option)
        {
            _option = option.Value;
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
            // Buscar todos ou filtrar.
            return Ok();
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
            // return NotFound(); << se não encontrar o parâmetro enviado, o retorno será Not Found. >>

            // Buscar o projeto.
            return Ok();
        }

        /* Notação FromBody
         * Que quer dizer corpo da requisição
         */
        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            if (createProject.Title.Length > 50)
            {
                return BadRequest();
            }

            /* Parâmetros do CreateAtAction
             * Nome da API que vai obter os detalhes dele, nesse caso seria ("GetById") que é o método acima.
             * nameof(GetByAction)....
             */

            //Cadastrar o projeto.
            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }

        // api/projects/2  << o número é o parâmetro recebido pelo método IActionResult >>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 200)
            {
                return BadRequest();
            }

            // Atualizo o objeto.
            return NoContent();
        }

        // api/projects/3
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Buscar, se não existir, retornar NotFound.

            // Remover
            return NoContent();
        }

        // api/projects/1/comments POST
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateCommentModel createComment)
        {
            return NoContent();
        }
        
        // api/projects/1/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        // api/projects/1/finish
        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }

    }
}
