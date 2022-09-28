using LittlePepLight.Models.Entities;
using LittlePepLight.Models.Repositories;
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

        [HttpGet("{id}")]
        public JsonResult BuscarAgenda(int id)
        {
            var services = new AgendamentoService();
            var agendamentos = services.BucarAgenda(id);
            return new JsonResult(agendamentos);
        }

        [HttpDelete("{id}")]
        public JsonResult Deletar(int id)
        {
            var repository = new AgendamentoRepository();
            repository.Deletar(id);   
            return Json("");
        }

        [HttpPost()]
        public JsonResult CriarAgenda(Agendamento agendamento)
        {
            var repository = new AgendamentoRepository();
            var agenda = repository.CriarAgenda(agendamento);
            return Json(agenda);
        }

    }
}
