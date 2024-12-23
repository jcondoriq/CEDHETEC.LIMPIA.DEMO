using CEDHETEC.LIMPIA.DEMO.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEDHETEC.LIMPIA.DEMO.Entities.Repositories
{
    public interface IRegisterStudentRepository
    {
        Task<int> Register(Student student);
    }
}
