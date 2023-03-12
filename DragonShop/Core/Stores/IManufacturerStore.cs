using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Stores
{
    public interface IManufacturerStore
    {
        public IEnumerable<ManufacturerCore> GetAll(bool includeTobaccos = false);
        public ManufacturerCore GetManufacturerByID(long id, bool includeTobbacos = false);
        public IEnumerable<ManufacturerCore> GetSortedByDescending();
        public Task CreateAsync(ManufacturerCore manufacturerCore);
        public Task UpdateAsync(ManufacturerCore manufacturerCore);
        public void Delete(long id);
    }
}
