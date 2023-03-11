using Core.Infrastructure;
using Core.Models;
using Core.Stores;
using DataAccess.EntityFramework.MSSQL.Infrastucture;
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
            IStrengthStore store = new StrengthStore(new DatabaseContext());
            var entities = store.GetAll();

            foreach (var entity in entities)
            {
                
                System.Console.WriteLine(entity);
            }
        }
    }
}
