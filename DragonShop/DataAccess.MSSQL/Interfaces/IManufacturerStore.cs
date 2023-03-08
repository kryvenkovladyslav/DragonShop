using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IManufacturerStore
    {
        public IEnumerable<ManufacturerDAL> GetAll();
        public Task<ManufacturerDAL> GetManufacturerByIDAsync(long id);
        public IEnumerable<ManufacturerDAL> GetSortedByDescending();
        public Task CreateAsync(ManufacturerDAL manufacturerDAL);
        public Task UpdateAsync(ManufacturerDAL manufacturerDAL);
        public void Delete(long id);
    }
}
