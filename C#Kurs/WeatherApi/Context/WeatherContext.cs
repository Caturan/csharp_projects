using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace WeatherApi.Context
{
    public class WeatherContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CAT\\SQLEXPRESS;Database=WeatherDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }
        public DbSet<Entities.City> Cities { get; set; }    
    }
}
