using LittlePepLight.Models.Entities;
using LittlePepLight.Models.Repositories;

namespace LittlePepLight.Models.Services
{
    public class PacienteService
    {
        
        public List<Paciente> Listar() 
        {
           var repositorio = new PacienteRepository();
           return repositorio.Listar();
        }
    }
}
