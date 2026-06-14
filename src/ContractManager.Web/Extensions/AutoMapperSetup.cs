using AutoMapper;
using ContractManager.Application.AutoMapper.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace ContractManager.Web.Extensions
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            services.AddAutoMapper(config =>
                config.AddProfile<EntityToCommandProfile>());
        }
    }
}
