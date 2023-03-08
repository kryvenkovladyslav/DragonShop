using AutoMapper;
using System.Collections.Generic;

namespace Core.Infrastructure
{
    public class Mapper<InputType, OutputType> 
    {
        private readonly MapperConfiguration configuration;
        private readonly Mapper mapper;
        public Mapper()
        {
            configuration = new MapperConfiguration(config => config.CreateMap<InputType, OutputType>());
            mapper = new Mapper(configuration);
        }   
        public OutputType MapSingle(InputType obj)
        {
            return mapper.Map<InputType, OutputType>(obj);
        }
        public IEnumerable<OutputType> MapCollection(IEnumerable<InputType> collection)
        {
            return mapper.Map<IEnumerable<InputType>, IEnumerable<OutputType>>(collection);
        }
    }
}
