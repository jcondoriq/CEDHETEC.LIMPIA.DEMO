using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEDHETEC.LIMPIA.DEMO.UseCases.Ports.RegisterStudent
{
    public interface IRegisterStudentInputPort
    {
        Task Handle(RegisterStudentRequestDto registerStudentDto);
    }
}
