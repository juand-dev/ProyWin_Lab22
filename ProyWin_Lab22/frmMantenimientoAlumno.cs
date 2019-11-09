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
    public partial class frmMantenimientoAlumno : Form
    {
        AlumnosNegocio alumnosNegocio = new AlumnosNegocio();
        frmDetalleMantenimientoAlumno frmDetMantAlumno = new frmDetalleMantenimientoAlumno();
        public static int IndexSelectAlumno = 0;        
        public frmMantenimientoAlumno()
        {
            InitializeComponent();
        }       

        private void frmAlumnoLista_Load(object sender, EventArgs e)
        {
            if ((dataGridView1.RowCount + 1) > 0)
            {
                dataGridView1.DataSource = alumnosNegocio.Listar();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }            
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            AlumnosNegocio.EstadoDetalleMantenimiento = 0;
            frmDetMantAlumno.FormClosed += frmAlumnoLista_FormClosed;
            frmDetMantAlumno.Location = new Point(10, 58);
            frmDetMantAlumno.ShowDialog();

        }
        private void frmAlumnoLista_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmDetMantAlumno.DialogResult == DialogResult.OK)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = alumnosNegocio.Listar();
                frmDetMantAlumno.DialogResult = DialogResult.Cancel;                
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            IndexSelectAlumno = IdAlumnoSelect();
            AlumnosNegocio.EstadoDetalleMantenimiento = 1;
            frmDetMantAlumno.FormClosed += frmAlumnoLista_FormClosed;            
            frmDetMantAlumno.ShowDialog();            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int IdAlumnoSelect()
        {
            return dataGridView1.CurrentRow.Index;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            alumnosNegocio.Delete(IdAlumnoSelect());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alumnosNegocio.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
