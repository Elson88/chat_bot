using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API_chat_postgreSQL.Controllers.Models
{
    public class Registo_chamada
    {
        public string consulta_telefone_cliente { get; set; }
        public string data_conversa { get; set; }
        public string consulta_especialidade { get; set; }
        public string consulta_nome_cliente { get; set; }
    }
}
