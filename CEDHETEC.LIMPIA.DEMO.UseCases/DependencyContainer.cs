using CEDHETEC.LIMPIA.DEMO.UseCases.Ports.RegisterStudent;
using CEDHETEC.LIMPIA.DEMO.UseCases.RegisterStudent;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEDHETEC.LIMPIA.DEMO.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCases(this IServiceCollection service)
        {
            service.AddScoped<IRegisterStudentInputPort, RegisterStudentInteractor>();

            return service;
        }
    }
}
