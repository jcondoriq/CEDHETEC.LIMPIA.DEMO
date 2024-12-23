using CEDHETEC.LIMPIA.DEMO.UseCases.Ports.RegisterStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEDHETEC.LIMPIA.DEMO.Presenters
{
    public class RegisterStudentPresenter : IRegisterStudentOutputPort, IPresenters<string>
    {
        public string Content { get; private set; }

        public Task Handle(int studentId)
        {
            Content = $"Se ha registrado el estudiante de código {studentId}";
            return Task.CompletedTask;
        }
    }
}
