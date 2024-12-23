using CEDHETEC.LIMPIA.DEMO.UseCases.Ports.RegisterStudent;
using Microsoft.Extensions.DependencyInjection;

namespace CEDHETEC.LIMPIA.DEMO.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection service)
        {
            service.AddScoped<IRegisterStudentOutputPort, RegisterStudentPresenter>();

            return service;
        }
    }
}
