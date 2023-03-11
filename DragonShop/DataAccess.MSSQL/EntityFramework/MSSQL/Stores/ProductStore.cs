using DataAccess.EntityFramework.MSSQL.Infrastucture;
using Core.Stores;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.MSSQL.Stores
{
    public sealed class ProductStore : IProductStore
    {
        private readonly DatabaseContext context;
        public ProductStore(DatabaseContext context)
            => this.context = context;
    }
}
