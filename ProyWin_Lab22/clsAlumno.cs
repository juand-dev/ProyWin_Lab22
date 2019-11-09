using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyWin_Lab22
{
    public sealed class clsAlumno : clsPersona
    {
        private bool _blnActivo;
        private DateTime _dtmFechaIngreso;

        public bool Activo
        {
            get
            {
                return _blnActivo;
            }

            set
            {
                _blnActivo = value;
            }
        }

        public DateTime FechaIngreso
        {
            get
            {
                return _dtmFechaIngreso;
            }

            set
            {
                _dtmFechaIngreso = value;
            }
        }
    }
}
