using API_chat_postgreSQL.Controllers.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_chat_postgreSQL.Controllers
{
    [Route("registo")]
    [ApiController]
    public class ChamadaController : Controller
    {
        public static List<Registo_chamada> lista = new List<Registo_chamada>();
        
        

        [HttpGet]
        public List<Registo_chamada> GetRegisto(string Contacto)
        {
            List<Registo_chamada> lista = RegistoDB.GetRegisto(Contacto);
            return lista;
        
    }
    }
}
