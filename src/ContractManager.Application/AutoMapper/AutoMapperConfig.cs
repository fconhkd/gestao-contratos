using AutoMapper;
using ContractManager.Application.AutoMapper.Profiles;
using Microsoft.Extensions.Logging.Abstractions;

namespace ContractManager.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration ConfigureMappings()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new EntityToCommandProfile());
            }, NullLoggerFactory.Instance);
            return mapperConfiguration;
        }
    }
}
