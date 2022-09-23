using LittlePepLight.Models.Entities;
using LittlePepLight.Models.Repositories;

namespace LittlePepLight.Models.Services
{
    public class ConvenioService
    {
        public List<Convenio> Listar()
        {
            var repositorio = new ConvenioRepository();
            return repositorio.Listar();
        }
    }
}
