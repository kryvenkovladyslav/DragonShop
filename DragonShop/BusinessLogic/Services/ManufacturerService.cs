using AutoMapper;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using Core.Interfaces;
using Core.Models;
using Core.Stores;
using System;
using System.Collections.Generic;
using System.Text;

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
            });

            Mapper mapper = new Mapper(configuration);
            var manufacturersBL = mapper.Map<IEnumerable<ManufacturerCore>, IEnumerable<ManufacturerBL>>(manufacturers);

            /*foreach (var manufacturer in manufacturersBL)
            {
                manufacturer.File = dataLoader.Load(manufacturer.DescriptionPath);
            }*/

            return manufacturersBL;


            
        }
    }
}
