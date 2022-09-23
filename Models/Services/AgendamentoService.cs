using LittlePepLight.Models.Entities;
using LittlePepLight.Models.Repositories;
using Oracle.ManagedDataAccess.Client;
using System.Drawing;

namespace LittlePepLight.Models.Services
{
    public class AgendamentoService
    {
        public List<Agendamento> Listar()
        {
            var repositorio = new AgendamentoRepository();
            return repositorio.Listar();
        }
    }

       
    
}
