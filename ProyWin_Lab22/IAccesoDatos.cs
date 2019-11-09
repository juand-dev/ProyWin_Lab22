using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyWin_Lab22
{
    interface IAccesoDatos
    {
        bool Created(clsAlumno objAlumno);
        List<clsAlumno> Read();
        bool Update(clsAlumno objAlumno, int intId);
        bool Delete(int intId);

    }
}
