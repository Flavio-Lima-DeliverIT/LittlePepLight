using Dapper;
using LittlePepLight.Models.Entities;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace LittlePepLight.Models.Repositories
{

    public class PacienteRepository
    {
        private readonly IDbConnection _conn;
        public PacienteRepository()
        {
            // criando connection com bd
            _conn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE))); User Id=Dev; Password=Dev1234;");
        }

        public List<Paciente> Listar()
        {
            var pacientes = _conn.Query<Paciente>("SELECT * FROM Dev.pacientes").ToList();
            return pacientes;
        }

        public Paciente BuscarPaciente(int id)
        {
            var pacientes = _conn.Query<Paciente>("SELECT * FROM Dev.pacientes WHERE ID_PACIENTE = '" + id + "'").FirstOrDefault();
            return pacientes;
        }

        public void Deletar(int id)
        {
            _conn.Query<Paciente>("DELETE FROM Dev.pacientes WHERE ID_PACIENTE = '" + id + "'");
            
        }
    }
}
