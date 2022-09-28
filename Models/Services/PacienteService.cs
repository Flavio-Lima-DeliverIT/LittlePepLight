using LittlePepLight.Models.Entities;
using LittlePepLight.Models.Repositories;

namespace LittlePepLight.Models.Services
{
    public class PacienteService
    {

        public List<Paciente> Listar()
        {
            var repository = new PacienteRepository();
            return repository.Listar();
        }

        public Paciente BucarPaciente(int id)
        {
            var repository = new PacienteRepository();
            return repository.BuscarPaciente(id);
        }

        public void Deletar(int id)
        {
            var repository = new PacienteRepository();
            repository.Deletar(id);
        }
    }
} 
