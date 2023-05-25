using API_chat_postgreSQL.Controllers.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_chat_postgreSQL.Controllers
{
    public class RegistoDB
    {
        public static List<Registo_chamada> GetRegisto(string Contacto)
        {
            List<Registo_chamada> lista = new List<Registo_chamada>();
            try
            {
                NpgsqlConnection conn = Connection.GetConnection();
                string sql = $"SELECT consulta_especialidade, consulta_nome_cliente FROM conversas_bot WHERE conversa_telefone = '{Contacto}' ORDER BY data_conversa DESC LIMIT 1";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string especialidade = dr["consulta_especialidade"].ToString();
                    string nome_cliente = dr["consulta_nome_cliente"].ToString();
;                    //string rua = dr["rua"].ToString();
                    Registo_chamada registo_chamada = new Registo_chamada();
                    registo_chamada.consulta_especialidade = especialidade;
                    registo_chamada.consulta_nome_cliente = nome_cliente;
                    lista.Add(registo_chamada);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro SQL: " + ex.Message);
            }
            return lista;
        }


    }
}