using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyWin_Lab22
{
    public class AlumnosNegocio
    {

        public static int EstadoDetalleMantenimiento = 0;
        public List<clsAlumno> Listar()
        {
            IAccesoDatos iAccesoDatos = new AccesoDatos();
            return iAccesoDatos.Read();
        }
        public bool Insertar(string strNombre, string strApellido, DateTime dtmFechaNacimiento, bool blnActivo, DateTime dtmFechaIngreso)
        {
            clsAlumno objAlumno = new clsAlumno();

            objAlumno.Id = GenerarId();
            objAlumno.Nombre = strNombre;
            objAlumno.Apellido = strApellido;
            objAlumno.FechaNacimiento = dtmFechaNacimiento;
            objAlumno.Activo = blnActivo;
            objAlumno.FechaIngreso = dtmFechaIngreso;

            IAccesoDatos iAccesoDatos = new AccesoDatos();
            return iAccesoDatos.Created(objAlumno);
        }

        public bool Update(int intId, string strNombre, string strApellido, DateTime dtmFechaNacimiento, bool blnActivo)
        {
            clsAlumno objAlumno = new clsAlumno();

            objAlumno.Nombre = strNombre;
            objAlumno.Apellido = strApellido;
            objAlumno.FechaNacimiento = dtmFechaNacimiento;
            objAlumno.Activo = blnActivo;
          
            IAccesoDatos iAccesoDatos = new AccesoDatos();
            return iAccesoDatos.Update(objAlumno, intId - 1);
        }

        public bool Delete(int intId)
        {
            IAccesoDatos iAccesoDatos = new AccesoDatos();
            return iAccesoDatos.Delete(intId);
        }
        private int GenerarId()
        {
            IAccesoDatos iAccesoDatos = new AccesoDatos();
            List<clsAlumno> lstAlumnos = iAccesoDatos.Read();

            if (lstAlumnos.Count == 0)            
                return lstAlumnos.Count + 1;            
            else
                return lstAlumnos.Last().Id + 1;
        }        
    }
}
