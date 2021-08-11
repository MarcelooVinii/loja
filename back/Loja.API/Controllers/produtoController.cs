using Microsoft.AspNetCore.Mvc;

namespace Loja.API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ProdutoController : ControllerBase {
        public ProdutoController(){}

        // Api com o metodo GET
        [HttpGet]
        public string Get(){
            return "Retorno de todos os produtos";
        }

        // Metodo GET com filtro (id)
        [HttpGet("{id}")]
        public string Get(int id){
            return $"Retorno do produto com id ={id}";
        }

        // API com o metodo POST
        [HttpPost]
        public string Post(){
            return "Exemplo de POST";
        }

        // API com o metodo PUT
        [HttpPut("{id}")]

        public string Put(int id){
            return $"Exemplo de PUT com id = {id}";
        }

        //API com o metodo DELETE
        [HttpDelete("{id}")]

        public string Delete(int id){
            return $"Exemplo de Delete = {id}";
        }

    }
}