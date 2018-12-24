using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer(@"Server=DESKTOP-7BGFQJH;Database=AjaxStudentMarks;Trusted_Connection=True;");
        // }

        public DataContext(DbContextOptions<DataContext>options) 
        : base (options) 
        {

        }

             public DbSet<Value> Values { get; set; }
     
       
    }
}