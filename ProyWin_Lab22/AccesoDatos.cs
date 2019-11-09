using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyWin_Lab22
{
    public class AccesoDatos : IAccesoDatos
    {
        public bool Created(clsAlumno objAlumno)
        {
            Datos.BdAlumnos.Add(objAlumno);
            return true;
        }

        public bool Delete(int id)
        {
            Datos.BdAlumnos.RemoveAt(id);
            return true;
        }

        public List<clsAlumno> Read()
        {
            return Datos.BdAlumnos;
        }

        public bool Update(clsAlumno objAlumno, int intId)
        {
            Datos.BdAlumnos[intId].Nombre = objAlumno.Nombre;
            Datos.BdAlumnos[intId].Apellido = objAlumno.Apellido;
            Datos.BdAlumnos[intId].Activo = objAlumno.Activo;
            Datos.BdAlumnos[intId].FechaNacimiento = objAlumno.FechaNacimiento;
            return true;
        }
    }
}
