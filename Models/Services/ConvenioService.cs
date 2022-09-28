using LittlePepLight.Models.Entities;
using LittlePepLight.Models.Repositories;

namespace LittlePepLight.Models.Services
{
    public class ConvenioService
    {
        public List<Convenio> Listar()
        {
            var repository = new ConvenioRepository();
            return repository.Listar();
        }

        public Convenio BuscarConvenio(int id)
        {
            var repository = new ConvenioRepository();
            return repository.BuscarConvenio(id);
        }

        public void Deletar(int id)
        {
            var repository = new ConvenioRepository();
            repository.Deletar(id);
        }
    }
}
