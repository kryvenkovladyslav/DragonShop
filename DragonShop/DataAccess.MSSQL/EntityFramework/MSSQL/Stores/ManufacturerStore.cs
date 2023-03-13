using Core.Stores;
using Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.EntityFramework.MSSQL.Infrastucture;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework.MSSQL.Stores
{
    public sealed class ManufacturerStore : IManufacturerStore
    {
        private readonly DatabaseContext context;
        public ManufacturerStore(DatabaseContext context)
            => this.context = context;

        public async Task CreateAsync(ManufacturerCore manufacturerDAL)
        {
            await context.Manufacturer.AddAsync(manufacturerDAL);
            context.SaveChanges();
        }
        public void Delete(long id)
        {
            context.Manufacturer.Remove(new ManufacturerCore { ID = id });
            context.SaveChanges();
        }
        public IEnumerable<ManufacturerCore> GetAll(bool includeTobaccos = false)
        {
            return includeTobaccos ?
                context.Manufacturer.Include(m => m.Tobaccos).ThenInclude(t => t.Product).OrderBy(manufacturer => manufacturer.Name).ToList() :
                context.Manufacturer.OrderBy(manufacturer => manufacturer.Name).ToList();
        }
        public ManufacturerCore GetManufacturerByID(long id, bool includeTobaccos = false)
        {
            return includeTobaccos ?
                context.Manufacturer.Include(m => m.Tobaccos).ThenInclude(t => t.Product).First(m => m.ID == id) :
                context.Manufacturer.Find(id);
        }
        public IEnumerable<ManufacturerCore> GetSortedByDescending()
        {
            return context.Manufacturer.OrderByDescending(manufacturer => manufacturer.Name).ToList();
        }
        public async Task UpdateAsync(ManufacturerCore manufacturerDAL)
        {
            var original = await context.Manufacturer.FindAsync(manufacturerDAL);
            original.Name = original.Name;
            original.ImagePath = manufacturerDAL.ImagePath;
            original.DescriptionPath = manufacturerDAL.DescriptionPath;
            context.SaveChanges();
        }
    }
}
