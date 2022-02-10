
using DevFreela.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        /* Entendimento de funcionamento até o momento.
         * Esse Get pode retornar uma lista filtrada pelo query string OU
         * removo o parâmetro "string query" do método e ele retorna tudo OU
         * por padrão retorna OK caso não encontre nada.
         */

        // api/projects?query=net core << a parte 'net core' é um exemplo da informação que vai  na URL. >>
        [HttpGet]
        public IActionResult Get(string query)
        {
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
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            if(creteProject.Title.Length > 50)
            {
                return BadRequest();
            }
        }
    }
}
