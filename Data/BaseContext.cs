using Microsoft.EntityFrameworkCore;
 using Backend2.Models; 

namespace Backend2.Data
{
    public class  BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options){

        }
        public DbSet<Nota> Notas { get; set; }

     
        
    }
}