using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Stores
{
    public interface IStrengthStore
    {
        public IEnumerable<StrengthCore> GetAll();
        public Task<StrengthCore> GetStengthByIDAsync(long id);
        public Task CreateAsync(StrengthCore strength);
        public void Update(StrengthCore strength);
        public void Delete(long id);
    }
}
