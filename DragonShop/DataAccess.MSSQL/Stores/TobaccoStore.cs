using DataAccess.MSSQL.Infrastructure;
using DataAccess.MSSQL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.MSSQL.Stores
{
    public sealed class TobaccoStore : ITobaccoStore
    {
        private readonly DatabaseContext context;
        public TobaccoStore(DatabaseContext context)
            => this.context = context;
    }
}
