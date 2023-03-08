using DataAccess.MSSQL.Infrastructure;
using DataAccess.MSSQL.Interfaces;
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
