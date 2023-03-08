using DataAccess.MSSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.MSSQL.Infrastructure
{
    public sealed class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<ManufacturerDAL> Manufacturer { get; private set; }
        public DbSet<StrengthDAL> Strength { get; private set; }
        public DbSet<ProductDAL> Product { get; private set; }
        public DbSet<TobaccoDAL> Tobacco { get; private set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=DragonShop;Trusted_Connection=True;");
        }
    }
}
