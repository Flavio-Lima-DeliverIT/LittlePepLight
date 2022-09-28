//using LittlePepLight.Models.Services;
//using Microsoft.AspNetCore.Mvc;
//using System.Web.Http;

using LittlePepLight.Models.Services;
using Microsoft.AspNetCore.Mvc;
//using System.Web.Http.Results;

namespace LittlePepLight.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : Controller
    {
        [HttpGet]
        public JsonResult Get()
        {
            var services = new PacienteService();
            var pacientes = services.Listar();
            return new JsonResult(pacientes);
        }

        [HttpGet("{id}")]
        public JsonResult BuscarPaciente(int id)
        {

            var services = new PacienteService();
            var pacientes = services.BucarPaciente(id);
            return new JsonResult(pacientes);
        }

        [HttpDelete("{id}")]
        public JsonResult Deletar(int id)
        {
            var services = new PacienteService();
            services.Deletar(id);
            return Json(services);
        }
    }
}
