using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Stores
{
    public interface IStrengthStore
    {
        public IEnumerable<StrengthCore> GetAll();
        public Task<StrengthCore> GetStengthByIDAsync(long id);
        public Task CreateAsync(StrengthCore strengthCore);
        public void Update(StrengthCore strengthCore);
        public void Delete(long id);
    }
}
