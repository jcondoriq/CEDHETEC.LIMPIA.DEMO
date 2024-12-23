using CEDHETEC.LIMPIA.DEMO.Controllers.Interfaces;
using CEDHETEC.LIMPIA.DEMO.Presenters;
using CEDHETEC.LIMPIA.DEMO.UseCases.Ports.RegisterStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEDHETEC.LIMPIA.DEMO.Controllers.Implements
{
    internal class RegisterStudentController : IRegisterStudentController
    {
        readonly IRegisterStudentInputPort InputPort;
        readonly IRegisterStudentOutputPort OutputPort;

        public RegisterStudentController(IRegisterStudentInputPort inputPort,
            IRegisterStudentOutputPort outputPort)
        {
            InputPort = inputPort;
            OutputPort = outputPort;
        }

        public async Task<string> Register(RegisterStudentRequestDto registerStudentRequestDto)
        {
            await InputPort.Handle(registerStudentRequestDto);
            var Presenter = OutputPort as IPresenters<string>;

            return Presenter.Content;
        }
    }
}
