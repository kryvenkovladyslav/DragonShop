using AutoMapper;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using Core.Interfaces;
using Core.Models;
using Core.Stores;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public sealed class ProductService : IProductService
    {
        private readonly IProductStore productStore;
        private readonly IDataLoader dataLoader;

        public ProductService(IProductStore productStore, IDataLoader dataLoader)
        {
            this.productStore = productStore;
            this.dataLoader = dataLoader;
        }

        public IEnumerable<ProductBL> GetAll(bool includeTobaccos)
        {
            var products = productStore.GetAll(includeTobaccos);

            MapperConfiguration configuration = new MapperConfiguration(config =>
            {
                config.CreateMap(typeof(StrengthCore), typeof(StrengthBL));
                config.CreateMap(typeof(TobaccoCore), typeof(TobaccoBL));
                config.CreateMap(typeof(ProductCore), typeof(ProductBL));

            });

            Mapper mapper = new Mapper(configuration);
            var productsBL = mapper.Map<IEnumerable<ProductCore>, IEnumerable<ProductBL>>(products);

            //manufacturerBL.File = dataLoader.Load(manufacturer.DescriptionPath);

            /*foreach (var manufacturerBL in manufacturersBL)
            {
                manufacturerBL
            }*/

            return productsBL;
        }

        public async Task<ProductBL> GetProduct(long id, bool includeTobbacos)
        {
            var product = await productStore.GetProductByID(id, includeTobbacos);

            MapperConfiguration configuration = new MapperConfiguration(config =>
            {
                config.CreateMap(typeof(StrengthCore), typeof(StrengthBL));
                config.CreateMap(typeof(TobaccoCore), typeof(TobaccoBL));
                config.CreateMap(typeof(ProductCore), typeof(ProductBL));

            });

            Mapper mapper = new Mapper(configuration);
            var productBL = mapper.Map<ProductCore, ProductBL>(product);

            //manufacturerBL.File = dataLoader.Load(manufacturer.DescriptionPath);

            /*foreach (var manufacturerBL in manufacturersBL)
            {
                manufacturerBL
            }*/

            return productBL;
        }
    }
}
