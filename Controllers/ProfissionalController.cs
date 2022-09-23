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
    }
}
