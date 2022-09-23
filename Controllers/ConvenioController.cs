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
    }
}
