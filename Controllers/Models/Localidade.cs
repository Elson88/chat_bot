using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace API_chat_postgreSQL.Controllers.Models
{
    [Keyless]
    public class Localidade
    {
        public string Local { get; set; }
        public string Rua { get; set; }
    }
}
