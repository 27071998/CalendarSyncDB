using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    public class Conexao
    {
        public static NpgsqlConnection PContatos { get; set; }



        public static MySqlConnection MContatos { get; set; }

        public static void ConectaPostgres()
        {
            string strConexao = "Server=127.0.0.1;Port=5432;Database=postgres;Userid=postgres;password=Agecom;Timeout=1000;";
            try
            {
                PContatos = new NpgsqlConnection(strConexao);
                PContatos.Open();
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
        }

        public static void Desconecta()
        {
            if (PContatos.State == ConnectionState.Open)
            {
                PContatos.Close();
            }

        }
    }
}
