using API_chat_postgreSQL.Controllers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API_chat_postgreSQL.Data
{
    public class API_chat_postgreSQLDBContext : DbContext
    {
        public API_chat_postgreSQLDBContext(DbContextOptions<API_chat_postgreSQLDBContext> options) : base(options) 
        {

        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql();

        }

        public DbSet<Localidade> Localidade { get; set; }
    }
}
