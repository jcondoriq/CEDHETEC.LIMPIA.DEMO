using CEDHETEC.LIMPIA.DEMO.Entities.Repositories;
using CEDHETEC.LIMPIA.DEMO.PersistenceEFCore.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CEDHETEC.LIMPIA.DEMO.PersistenceEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection service)
        {
            service.AddScoped<IRegisterStudentRepository, RegisterStudentRepository>();

            return service;
        }
    }
}
