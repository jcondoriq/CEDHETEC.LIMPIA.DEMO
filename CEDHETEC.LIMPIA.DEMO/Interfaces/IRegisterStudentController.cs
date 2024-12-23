using CEDHETEC.LIMPIA.DEMO.UseCases.Ports.RegisterStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEDHETEC.LIMPIA.DEMO.Controllers.Interfaces
{
    public interface IRegisterStudentController
    {
        Task<string> Register(RegisterStudentRequestDto registerStudentRequestDto);
    }
}
