using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    public class DbHelper
    {

        public DataTable CarregaCbbNome ()
        {
            Conexao.ConectaPostgres();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.CommandText = "SELECT  cod_index, nome FROM agendacontatos.contatos";
            comm.Connection = Conexao.PContatos;
            DataTable dtContatos = new DataTable();
            NpgsqlDataReader drContatos = comm.ExecuteReader();
            dtContatos.Load(drContatos);
            Conexao.Desconecta();
            return dtContatos;
        }

    }
}
