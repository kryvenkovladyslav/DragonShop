using DataAccess.MSSQL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.MSSQL.Interfaces
{
    public interface IStrengthStore
    {
        public IEnumerable<StrengthDAL> GetAll();
        public Task<StrengthDAL> GetStengthByIDAsync(long id);
        public Task CreateAsync(StrengthDAL strength);
        public void Update(StrengthDAL strength);
        public void Delete(long id);
    }
}
