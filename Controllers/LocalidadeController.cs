using API_chat_postgreSQL.Controllers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_chat_postgreSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalidadeController : ControllerBase
    {
        public static List<Localidade> lista = new List<Localidade>();


        [HttpGet]
        public List<Localidade> GetLocalidades(string Especialidade)
        {
            List<Localidade> lista = LocalidadeDB.GetLocalidades(Especialidade);
            return lista;
        }

        [HttpPost]
        public string PostLocalidade(Localidade localidade)
        {
            lista.Add(localidade);
            return "Localidade registrada com sucesso";
        }

        [HttpPut]
        public string PutLocalidade(Localidade localidade)
        {
            Localidade LocalidadeAux = lista.Where(x => x.Local == localidade.Local).FirstOrDefault();
            LocalidadeAux.Rua = localidade.Rua;
            return "Localidade alterada com sucesso";
        }


    }
}
