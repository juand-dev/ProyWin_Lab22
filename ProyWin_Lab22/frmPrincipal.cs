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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            AlumnosNegocio alumnosController = new AlumnosNegocio();
            alumnosController.Insertar("Juan Daniel", "Perez Soto", DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy")), true, DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy")));
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Controls.Find("frmMantenimientoAlumno", true).Count() == 0)
            {
                frmMantenimientoAlumno frmMantenimientoAlumno = new frmMantenimientoAlumno();
                frmMantenimientoAlumno.MdiParent = this;
                frmMantenimientoAlumno.Show();
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.Controls.Find("frmDetalleMantenimientoAlumno", true).Count() == 0)
            {
                frmDetalleMantenimientoAlumno frmDetalleMantenimientoAlumno = new frmDetalleMantenimientoAlumno();
                frmDetalleMantenimientoAlumno.MdiParent = this;
                frmDetalleMantenimientoAlumno.Show();
            }
        }
    }
}
