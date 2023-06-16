using ApiDriver.Dto;
using ApiDriver.Models;
using AutoMapper;

namespace ApiDriver
{
    public class MappingConfig
    {
        //public static  MappingConfig 
        public static MapperConfiguration DriverMap()
        {
             var mappingConfig = new MapperConfiguration(config => { 
                    config.CreateMap<DriverDto, Conductores>();
                    config.CreateMap<Conductores, DriverDto>();
             });
            return mappingConfig;
        }

    }
}
