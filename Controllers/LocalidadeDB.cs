using API_chat_postgreSQL.Controllers.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_chat_postgreSQL.Controllers
{
    public class LocalidadeDB
    {
        public static List<Localidade> GetLocalidades(string Especialidade)
        {
            List<Localidade> lista = new List<Localidade>();
            try
            {
                NpgsqlConnection conn  = Connection.GetConnection();
                conn.Open();
                string sql = $"SELECT  moradas.localidade from moradas, especialidades, clinicas, clinica_especialidade where clinica_especialidade.id_clinica = clinicas.id_clinica and especialidades.id_especialidade = clinica_especialidade.id_especialidade and clinicas.id_endereco = moradas.id_endereco and especialidades.nome_especialidade = '{Especialidade}'";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string local = dr["localidade"].ToString();
                    //string rua = dr["rua"].ToString();
                    Localidade localidade = new Localidade();
                    localidade.Local = local;
                    lista.Add(localidade);
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
