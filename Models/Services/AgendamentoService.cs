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

        public Agendamento BucarAgenda(int id)
        {
            var agendamento = new AgendamentoRepository();
            return agendamento.BuscarAgenda(id);
        }

        public Agendamento CriarAgenda(Agendamento agendamento)
        {
            //Implements here the code
            return agendamento;
        }

        public void Deletar(int id)
        {
            var agendamento = new AgendamentoRepository();
            agendamento.Deletar(id);
        }


    }



}
