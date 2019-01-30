using Microsoft.EntityFrameworkCore;
using SmartHome.Database.Models;

namespace SmartHome.Database.Contexts
{
    public class DevicesContext : DbContext
    {
        public DbSet<Devices> Devices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=SmartHome;User Id=SA;Password = P@55w0rd;");
        }
    }
}