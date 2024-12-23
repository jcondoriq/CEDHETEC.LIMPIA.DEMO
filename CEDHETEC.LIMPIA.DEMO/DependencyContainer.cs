using CEDHETEC.LIMPIA.DEMO.Controllers.Implements;
using CEDHETEC.LIMPIA.DEMO.Controllers.Interfaces;
using CEDHETEC.LIMPIA.DEMO.Presenters;
using CEDHETEC.LIMPIA.DEMO.UseCases.Ports.RegisterStudent;
using Microsoft.Extensions.DependencyInjection;

namespace CEDHETEC.LIMPIA.DEMO.Controllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddControllersService(this IServiceCollection service)
        {
            service.AddScoped<IRegisterStudentController, RegisterStudentController>();

            return service;
        }
    }
}
