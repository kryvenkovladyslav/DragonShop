using AutoMapper;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using Core.Interfaces;
using Core.Models;
using Core.Stores;
using System.Collections.Generic;

namespace BusinessLogic.Services
{
    public sealed class ManufacturerService : IManufacturerService
    {
        private readonly IManufacturerStore manufacturerStore;
        private readonly IDataLoader dataLoader;
        
        public ManufacturerService(IManufacturerStore manufacturerStore, IDataLoader dataLoader)
        {
            this.manufacturerStore = manufacturerStore;
            this.dataLoader = dataLoader;
        }

        public IEnumerable<ManufacturerBL> GetAll(bool includeTobaccos)
        {
            var manufacturers = manufacturerStore.GetAll(includeTobaccos);

            MapperConfiguration configuration = new MapperConfiguration(config =>
            {
                config.CreateMap(typeof(ManufacturerCore), typeof(ManufacturerBL));
                config.CreateMap(typeof(TobaccoCore), typeof(TobaccoBL));
                config.CreateMap(typeof(ProductCore), typeof(ProductBL));

            });

            Mapper mapper = new Mapper(configuration);
            var manufacturersBL = mapper.Map<IEnumerable<ManufacturerCore>, IEnumerable<ManufacturerBL>>(manufacturers);

            //manufacturerBL.File = dataLoader.Load(manufacturer.DescriptionPath);

            /*foreach (var manufacturerBL in manufacturersBL)
            {
                manufacturerBL
            }*/

            return manufacturersBL;
        }

        public ManufacturerBL GetManufacturer(long id, bool includeTobbacos)
        {
            var manufacturer = manufacturerStore.GetManufacturerByID(id, includeTobbacos);

            MapperConfiguration configuration = new MapperConfiguration(config =>
            {
                config.CreateMap(typeof(ManufacturerCore), typeof(ManufacturerBL));
                config.CreateMap(typeof(TobaccoCore), typeof(TobaccoBL));
                config.CreateMap(typeof(ProductCore), typeof(ProductBL));

            });

            Mapper mapper = new Mapper(configuration);
            var manufacturerBL = mapper.Map<ManufacturerCore, ManufacturerBL>(manufacturer);

            manufacturerBL.File = dataLoader.Load(manufacturer.DescriptionPath);

            return manufacturerBL;
        }
    }
}
