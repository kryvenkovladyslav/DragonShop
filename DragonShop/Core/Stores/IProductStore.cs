using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Stores
{
    public interface IProductStore
    {
        public IEnumerable<ProductCore> GetAll(bool includeTobaccos = false);
        public Task<ProductCore> GetProductByID(long id, bool includeTobaccos = false);
        public Task CreateAsync(ProductCore productCore);
        public Task UpdateAsync(ProductCore productCore);
        public void Delete(long id);
    }
}
