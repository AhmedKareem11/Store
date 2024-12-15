using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Store.Dal.Repositories;
using Store.Domain.Abstractions.Repositories;
using Store.Domain.Entities;


namespace Store.Dal
{
    public static class dependencyInjection
    {
        public static IServiceCollection AddDataAccssesDependencies(this IServiceCollection services)
        {
           return services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
