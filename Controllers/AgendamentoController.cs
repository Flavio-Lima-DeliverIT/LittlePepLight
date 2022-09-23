using LittlePepLight.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace LittlePepLight.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendamentoController : Controller
    {
        [HttpGet]
        public JsonResult Get()
        {
            var services = new AgendamentoService();
            var agendamentos = services.Listar();
            return new JsonResult(agendamentos);
        }
    }
}
