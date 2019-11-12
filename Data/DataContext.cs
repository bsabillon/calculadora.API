using calculadora.API.Models;
using Microsoft.EntityFrameworkCore;



namespace calculadora.API.Data
{
    public class DataContext: DbContext
    {

        public DbSet<Operations> Operations {get;set;}
        public DataContext(DbContextOptions<DataContext> options): base(options){

           
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

             modelBuilder.Entity<Operations>().HasKey(operation=> operation.OperationId);

        }


    }
}