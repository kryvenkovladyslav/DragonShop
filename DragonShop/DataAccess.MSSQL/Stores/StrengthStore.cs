using DataAccess.MSSQL.Infrastructure;
using DataAccess.MSSQL.Interfaces;
using DataAccess.MSSQL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.MSSQL.Stores
{
    public sealed class StrengthStore : IStrengthStore
    {
        private readonly DatabaseContext context;
        public StrengthStore(DatabaseContext context)
            => this.context = context;

        public async Task CreateAsync(StrengthDAL strength)
        {
            await context.Strength.AddAsync(strength);
            context.SaveChanges();
        }
        public void Delete(long id)
        {
            context.Strength.Remove(new StrengthDAL { ID = id });
            context.SaveChanges();
        }
        public IEnumerable<StrengthDAL> GetAll()
        {
            return context.Strength.OrderBy(strength => strength.ID).ToList();
        }
        public async Task<StrengthDAL> GetStengthByIDAsync(long id)
        {
            return await context.Strength.FindAsync(id);
        }
        public void Update(StrengthDAL strength)
        {
            context.Strength.Update(strength);
            context.SaveChanges();
        }
    }
}
