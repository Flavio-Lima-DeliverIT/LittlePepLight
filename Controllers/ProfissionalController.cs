using LittlePepLight.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace LittlePepLight.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfissionalController : Controller
    {
        [HttpGet]
        public JsonResult Get()
        {
            var services = new ProfissionalService();
            var profissionais = services.Listar();
            return new JsonResult(profissionais);
        }

        [HttpGet("{id}")]
        public JsonResult BuscarProfissional(int id)
        {
            var services = new ProfissionalService();
            var profissionais = services.BuscarProfissional(id);
            return new JsonResult(profissionais);
        }

        [HttpDelete("{id}")]
        public JsonResult Deletar(int id)
        {
            var services = new ProfissionalService();
            services.Deletar(id);
            return new JsonResult("");
        }
    }
}
