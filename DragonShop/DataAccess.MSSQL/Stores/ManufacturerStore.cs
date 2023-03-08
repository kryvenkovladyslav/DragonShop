using DataAccess.MSSQL.Infrastructure;
using DataAccess.MSSQL.Interfaces;
using DataAccess.MSSQL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.MSSQL.Stores
{
    public sealed class ManufacturerStore : IManufacturerStore
    {
        private readonly DatabaseContext context;
        public ManufacturerStore(DatabaseContext context)
            => this.context = context;

        public async Task CreateAsync(ManufacturerDAL manufacturerDAL)
        {
            await context.Manufacturer.AddAsync(manufacturerDAL);
            context.SaveChanges();
        }
        public void Delete(long id)
        {
            context.Manufacturer.Remove(new ManufacturerDAL { ID = id });
            context.SaveChanges();
        }
        public IEnumerable<ManufacturerDAL> GetAll()
        {
            return context.Manufacturer.OrderBy(manufacturer => manufacturer.Name).ToList();
        }
        public async Task<ManufacturerDAL> GetManufacturerByIDAsync(long id)
        {
            return await context.Manufacturer.FindAsync(id);
        }
        public IEnumerable<ManufacturerDAL> GetSortedByDescending()
        {
            return context.Manufacturer.OrderByDescending(manufacturer => manufacturer.Name).ToList();
        }
        public async Task UpdateAsync(ManufacturerDAL manufacturerDAL)
        {
            var original = await context.Manufacturer.FindAsync(manufacturerDAL);
            original.Name = original.Name;
            original.ImagePath = manufacturerDAL.ImagePath;
            original.DescriptionPath = manufacturerDAL.DescriptionPath;
            context.SaveChanges();
        }
    }
}
