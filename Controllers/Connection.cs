using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace API_chat_postgreSQL.Controllers
{
    public class Connection
    {
        public static NpgsqlConnection GetConnection()
        {
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Estagio.2023;Database=clinicas_saude");
                conn.Open();
            }catch (Exception ex)
            {
                Console.WriteLine("erro ligaçao: " + ex.Message);
            }
            return conn;
        }

        public static void  SetCloseConnection(NpgsqlConnection conn) 
        {
            if(conn != null)
            {
                try
                {
                    conn.Close();
                }catch(Exception ex)
                {
                    Console.WriteLine("Erro a fechar ligaçao: " + ex.Message);
                }
            }
        }
    }
}
