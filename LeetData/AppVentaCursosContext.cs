using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeetData
{
    public class AppVentaCursosContext :  DbContext
    {
        private const string connectionString =  @"Data Source=DESKTOP-TAPJQEJ\SQLEXPRESS;Initial Catalog=CursosOnline;Integrated Security =True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(connectionString);

        }

        public DbSet<Curso> Curso{get;set;}


    }
}