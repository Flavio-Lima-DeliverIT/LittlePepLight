using LittlePepLight.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace LittlePepLight.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConvenioController : Controller
    {
        [HttpGet]
        public JsonResult Get()
        {
            var services = new ConvenioService();
            var convenios = services.Listar();
            return new JsonResult(convenios);
        }

        [HttpGet("{id}")]
        public JsonResult BuscarConvenio(int id)
        {
            var services = new ConvenioService();
            var convenios = services.BuscarConvenio(id);
            return new JsonResult(convenios);
        }

        [HttpDelete("{id}")]
        public JsonResult Deletar(int id)
        {
            var repository = new ConvenioService();
            repository.Deletar(id);
            return new JsonResult("");
        }
    }
}
