using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Stores
{
    public interface ITobaccoStore
    {
        public IEnumerable<TobaccoCore> GetAll();
        public Task<TobaccoCore> GetTobaccoByIDAsync(long id);
        public IEnumerable<TobaccoCore> GetSorted
            (ManufacturerCore manufacturerDAL = null, double? weight = null, bool? isSmoky = null, bool? isMixed = null);
        public Task CreateAsync(TobaccoCore tobaccoDAL);
        public Task UpdateAsync(TobaccoCore tobaccoDAL);
        public void Delete(long id);
    }
}
