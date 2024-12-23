using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEDHETEC.LIMPIA.DEMO.Presenters
{
    public interface IPresenters<FormaterDataType>
    {
        public FormaterDataType Content { get;}
    }
}
