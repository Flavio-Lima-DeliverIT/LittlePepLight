﻿using Dapper;
using LittlePepLight.Models.Entities;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Drawing;

namespace LittlePepLight.Models.Repositories
{
   
    public class AgendamentoRepository
    {
        private readonly IDbConnection _conn;
        public AgendamentoRepository()
        {
            // criando connection com bd
            _conn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE))); User Id=Dev; Password=Dev1234;");
        }

        public List<Agendamento> Listar()
        {
            var agendamento = _conn.Query<Agendamento>("SELECT * FROM Dev.agendamento").ToList();
            return agendamento;
        }
    }
}
