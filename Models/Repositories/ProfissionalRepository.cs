using Dapper;
using LittlePepLight.Models.Entities;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace LittlePepLight.Models.Repositories
{
    public class ProfissionalRepository
    {
        private readonly IDbConnection _conn;

        public ProfissionalRepository()
        {
            // criando connection com bd
            _conn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE))); User Id=Dev; Password=Dev1234;");
        }

        public List<Profissional> Listar()
        {
            var profissionais = _conn.Query<Profissional>("SELECT * FROM Dev.profissionais").ToList();
            return profissionais;
        }
    }
}
