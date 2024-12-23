using CEDHETEC.LIMPIA.DEMO.Entities.POCOs;
using CEDHETEC.LIMPIA.DEMO.Entities.Repositories;

namespace CEDHETEC.LIMPIA.DEMO.PersistenceEFCore.Repositories
{
    internal class RegisterStudentRepository : IRegisterStudentRepository
    {
        public Task<int> Register(Student student)
        {
            Console.WriteLine("Registrando al estudiante");
            return Task.FromResult(1);
        }
    }
}
