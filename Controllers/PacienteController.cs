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
    }
}
