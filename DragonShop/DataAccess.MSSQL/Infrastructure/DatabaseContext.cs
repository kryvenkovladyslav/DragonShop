using DataAccess.MSSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.MSSQL.Infrastructure
{
    public sealed class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Manufacturer> Manufacturers { get; private set; }
        public DbSet<Strength> Strengths { get; private set; }
        public DbSet<Product> Products { get; private set; }
        public DbSet<Tobacco> Tobaccos { get; private set; }
    }
}
