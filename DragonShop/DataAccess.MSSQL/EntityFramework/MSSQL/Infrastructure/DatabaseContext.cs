using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework.MSSQL.Infrastucture
{
    public sealed class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<ManufacturerCore> Manufacturer { get; private set; }
        public DbSet<StrengthCore> Strength { get; private set; }
        public DbSet<ProductCore> Product { get; private set; }
        public DbSet<TobaccoCore> Tobacco { get; private set; }
    }
}
