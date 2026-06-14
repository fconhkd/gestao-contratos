using ContractManager.Domain.Commands.Contract;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ContractManager.Web.Extensions
{
    public static class MediatRSetup
    {
        public static void AddMediatRSetup(this IServiceCollection services) =>
            services.AddMediatR(config =>
                config.RegisterServicesFromAssembly(typeof(ContractHandler).Assembly));
    }
}
