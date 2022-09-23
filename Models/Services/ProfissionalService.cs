using LittlePepLight.Models.Entities;
using LittlePepLight.Models.Repositories;

namespace LittlePepLight.Models.Services
{
    public class ProfissionalService
    {
        public List<Profissional> Listar()
        {
            var repositorio = new ProfissionalRepository();
            return repositorio.Listar();
        }
    }
}
