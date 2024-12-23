using CEDHETEC.LIMPIA.DEMO.Entities.POCOs;
using CEDHETEC.LIMPIA.DEMO.Entities.Repositories;
using CEDHETEC.LIMPIA.DEMO.UseCases.Ports.RegisterStudent;

namespace CEDHETEC.LIMPIA.DEMO.UseCases.RegisterStudent
{
    internal class RegisterStudentInteractor : IRegisterStudentInputPort
    {
        readonly IRegisterStudentRepository RegisterStudentRepository;
        readonly IRegisterStudentOutputPort OutputPort;

        public RegisterStudentInteractor(IRegisterStudentRepository registerStudentRepository,
            IRegisterStudentOutputPort outputPort)
        {
            RegisterStudentRepository = registerStudentRepository;
            OutputPort = outputPort;
        }

        public async Task Handle(RegisterStudentRequestDto registerStudentDto)
        {
            int studentId = 0;
            Student NewStudent = new Student
            {
                Name = registerStudentDto.Name,
                Lastname = registerStudentDto.Lastname,
            };

            studentId = await RegisterStudentRepository.Register(NewStudent);

            await OutputPort.Handle(studentId);
        }
    }
}
