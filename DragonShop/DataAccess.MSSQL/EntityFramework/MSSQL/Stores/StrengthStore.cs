using DataAccess.EntityFramework.MSSQL.Infrastucture;
using Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Stores;

namespace DataAccess.MSSQL.Stores
{
    public sealed class StrengthStore : IStrengthStore
    {
        private readonly DatabaseContext context;
        public StrengthStore(DatabaseContext context)
            => this.context = context;

        public async Task CreateAsync(StrengthCore strength)
        {
            await context.Strength.AddAsync(strength);
            context.SaveChanges();
        }
        public void Delete(long id)
        {
            context.Strength.Remove(new StrengthCore { ID = id });
            context.SaveChanges();
        }
        public IEnumerable<StrengthCore> GetAll()
        {
            return context.Strength.OrderBy(strength => strength.ID).ToList();
        }
        public async Task<StrengthCore> GetStengthByIDAsync(long id)
        {
            return await context.Strength.FindAsync(id);
        }
        public void Update(StrengthCore strength)
        {
            context.Strength.Update(strength);
            context.SaveChanges();
        }
    }
}
