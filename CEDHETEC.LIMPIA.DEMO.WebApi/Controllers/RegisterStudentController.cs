using CEDHETEC.LIMPIA.DEMO.Controllers.Interfaces;
using CEDHETEC.LIMPIA.DEMO.UseCases.Ports.RegisterStudent;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CEDHETEC.LIMPIA.DEMO.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterStudentController : ControllerBase
    {
        readonly IRegisterStudentController Controller;

        public RegisterStudentController(IRegisterStudentController controller)
        {
            Controller = controller;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterStudent(RegisterStudentRequestDto registerStudentRequestDto)
        {
            return Ok(await Controller.Register(registerStudentRequestDto));
        }
    }
}
