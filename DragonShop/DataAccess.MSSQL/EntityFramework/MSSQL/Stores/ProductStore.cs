using DataAccess.EntityFramework.MSSQL.Infrastucture;
using Core.Stores;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess.MSSQL.Stores
{
    public sealed class ProductStore : IProductStore
    {
        private readonly DatabaseContext context;
        public ProductStore(DatabaseContext context)
            => this.context = context;

        public Task CreateAsync(ProductCore productCore)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductCore> GetAll(bool includeTobaccos = false)
        {
            return includeTobaccos ?
                context.Product.Include(p => p.Tobacco).ThenInclude(t => t.Strength).ToList() :
                context.Product.ToList();
        }

        public async Task<ProductCore> GetProductByID(long id, bool includeTobaccos = false)
        {
            return includeTobaccos ?
                await context.Product.Include(p => p.Tobacco).ThenInclude(t => t.Strength).FirstAsync(p => p.ID == id) :
                await context.Product.FirstAsync(p => p.ID == id);
        }

        public Task UpdateAsync(ProductCore productCore)
        {
            throw new NotImplementedException();
        }
    }
}
