using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyWin_Lab22
{
    public abstract class clsPersona
    {
        private int _intId;
        private string _strNombre;
        private string _strApellido;
        private DateTime _dtmFechaNacimiento;
        public int Id
        {
            get
            {
                return _intId;
            }

            set
            {
                _intId = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _strNombre;
            }

            set
            {
                _strNombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _strApellido;
            }

            set
            {
                _strApellido = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return _dtmFechaNacimiento;
            }

            set
            {
                _dtmFechaNacimiento = value;
            }
        }
    }
}
