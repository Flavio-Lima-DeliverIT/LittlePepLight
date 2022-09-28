using LittlePepLight.Models.Entities;
using LittlePepLight.Models.Repositories;

namespace LittlePepLight.Models.Services
{
    public class ProfissionalService
    {
        public List<Profissional> Listar()
        {
            var repository = new ProfissionalRepository();
            return repository.Listar();
        }

        public Profissional BuscarProfissional(int id)
        {
            var repository = new ProfissionalRepository();
            return repository.BuscarProfissional(id);
        }

        public void Deletar(int id)
        {
            var repository = new ProfissionalRepository();
            repository.Deletar(id);
        }
    }
}
