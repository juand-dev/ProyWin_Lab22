using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyWin_Lab22
{
    public partial class frmDetalleMantenimientoAlumno : Form
    {
        AlumnosNegocio alumnosNegocio = new AlumnosNegocio();
        public frmDetalleMantenimientoAlumno()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            StringBuilder Message = new StringBuilder();

            try
            {
                if (AlumnosNegocio.EstadoDetalleMantenimiento == 0)
                {
                    if (alumnosNegocio.Insertar(txtNombres.Text, txtApellidos.Text, DateTime.Parse(dtmFechaNacimiento.Text), chkActivo.Checked, DateTime.Parse(dtmFechaIngreso.Text)))
                    {
                        MessageBox.Show($"Alumno {txtNombres.Text} {txtApellidos.Text} ingresado correctamente.");
                        DialogResult = DialogResult.OK;
                        Limpiar();
                        Iniciar();
                    }
                    else
                    {
                        Message.Append("No se pudo registrar Alumno.");
                    }
                }
                else 
                    if (AlumnosNegocio.EstadoDetalleMantenimiento == 1)                
                    {
                        if (alumnosNegocio.Update(int.Parse(txtId.Text), txtNombres.Text, txtApellidos.Text, DateTime.Parse(dtmFechaNacimiento.Text), chkActivo.Checked))
                        {
                            MessageBox.Show($"Datos de alumno {txtNombres.Text} {txtApellidos.Text} Actualizado correctamente.");
                            DialogResult = DialogResult.OK;
                            Limpiar();
                            Iniciar();
                        }
                        else
                        {
                            Message.Append("No se pudo actualizar datos de Alumno.");
                        }
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Message.Append($"\nError: {ex.Message}").ToString(), "Advertencia!");
            }           
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Iniciar();
        }
        private void Limpiar()
        {
            txtId.Text = String.Empty;
            txtNombres.Text = String.Empty;
            txtApellidos.Text = String.Empty;
            dtmFechaIngreso.Text = DateTime.Now.ToString();
            dtmFechaNacimiento.Text = DateTime.Now.ToString();
            chkActivo.Checked = false;           
        }
        private void Iniciar()
        {
            txtNombres.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAlumnoAgregar_Activated(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void frmDetalleMantenimientoAlumno_Load(object sender, EventArgs e)
        {
            Limpiar();
            if (AlumnosNegocio.EstadoDetalleMantenimiento == 1)
            {
                clsAlumno objAlumno = new clsAlumno();

                objAlumno = alumnosNegocio.Listar().ElementAt(frmMantenimientoAlumno.IndexSelectAlumno);
                txtId.Text = objAlumno.Id.ToString();
                txtNombres.Text = objAlumno.Nombre;
                txtApellidos.Text = objAlumno.Apellido;
                dtmFechaIngreso.Text = objAlumno.FechaIngreso.ToString();
                chkActivo.Checked = objAlumno.Activo;
                dtmFechaNacimiento.Text = objAlumno.FechaNacimiento.ToString();               
            }            
        }
    }
}
