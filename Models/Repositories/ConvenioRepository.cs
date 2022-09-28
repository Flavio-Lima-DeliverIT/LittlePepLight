using Dapper;
using LittlePepLight.Models.Entities;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Drawing;

namespace LittlePepLight.Models.Repositories
{
    public class ConvenioRepository
    {
        private readonly IDbConnection _conn;
        public ConvenioRepository()
        {
            // criando connection com bd
            _conn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE))); User Id=Dev; Password=Dev1234;");
        }

        public List<Convenio> Listar()
        {
            var convenios = _conn.Query<Convenio>("SELECT * FROM Dev.convenios").ToList();
            return convenios;
        }

        public Convenio BuscarConvenio(int id)
        {
            var convenios = _conn.Query<Convenio>("SELECT * FROM Dev.convenios WHERE ID_CONVENIO = '" + id + "'").FirstOrDefault();
            return convenios;
        }

        public void Deletar(int id)
        {
            _conn.Query<Convenio>("DELETE FROM Dev.convenios WHERE ID_CONVENIO = '" + id + "'");
            
        }
    }
}
