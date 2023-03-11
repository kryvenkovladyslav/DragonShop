using Core.Models;
using Core.Stores;
using DataAccess.EntityFramework.MSSQL.Infrastucture;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MSSQL.Stores
{
    public sealed class TobaccoStore : ITobaccoStore
    {
        private readonly DatabaseContext context;
        public TobaccoStore(DatabaseContext context)
            => this.context = context;

        public Task CreateAsync(TobaccoCore tobaccoDAL)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TobaccoCore> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TobaccoCore> GetSorted(ManufacturerCore manufacturerDAL = null, double? weight = null, bool? isSmoky = null, bool? isMixed = null)
        {
            throw new NotImplementedException();
        }

        public Task<TobaccoCore> GetTobaccoByIDAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TobaccoCore tobaccoDAL)
        {
            throw new NotImplementedException();
        }
    }
}
