using Core.Infrastructure;
using DataAccess.MSSQL.Infrastructure;
using DataAccess.MSSQL.Models;
using DataAccess.MSSQL.Stores;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StrengthStore store = new StrengthStore(new DatabaseContext());
            var entities = store.GetAll();

            foreach (var entity in entities)
            {
                
                System.Console.WriteLine(entity);
            }
        }
    }
}
