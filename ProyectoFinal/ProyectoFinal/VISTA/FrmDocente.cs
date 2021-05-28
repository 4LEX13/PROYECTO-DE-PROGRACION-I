using ProyectoFinal.DAO;
using ProyectoFinal.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.VISTA
{
    public partial class FrmDocente : Form
    {
        public FrmDocente()
        {
            InitializeComponent();
            Carga();
            clear();
        }

        void clear()
        {

            txtIdDocente.Clear();
            txtNombreDocente.Clear();
            txtApellidoDocente.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtDui.Clear();
            txtEmail.Clear();
            dtpFecha.Value = DateTime.Now.Date;

        }

        void Carga()
        {

            //dgvDocente.Rows.Clear();
            //using (GestorEstudiantesEntities db = new GestorEstudiantesEntities())
            //{
            //    var Lista = db.Docente.ToList();

            //    foreach (var iteracion in Lista)
            //    {
            //        dgvDocente.Rows.Add(iteracion.docenteid, iteracion.nombre, iteracion.apellido, iteracion.dui, iteracion.nacimiento, iteracion.dirreccion, iteracion.telefono, iteracion.email);
            //    }
            //}
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistarDocente_Click(object sender, EventArgs e)
        {

            //ClsDDocentes clsDUserList = new ClsDDocentes();
            //Docente userList = new Docente();
            //userList.nombre = txtNombreDocente.Text;
            //userList.apellido = txtApellidoDocente.Text;
            //userList.dui = txtDui.Text;
            //userList.nacimiento = dtpFecha.Value;
            //userList.dirreccion = txtDireccion.Text;
            //userList.email = txtEmail.Text;
            //userList.telefono = txtTelefono.Text;
          

            //clsDUserList.SaveDatosUser(userList);

            Carga();
            clear();

        }

        private void btnModificarDocente_Click(object sender, EventArgs e)
        {
            //ClsDDocentes clsDUserList = new ClsDDocentes();
            //Docente userList = new Docente();
            //userList.nombre = txtNombreDocente.Text;
            //userList.dirreccion = txtDireccion.Text;
            //userList.nacimiento = dtpFecha.Value;
            //userList.dui = txtDui.Text;
            //userList.email = txtEmail.Text;

            //clsDUserList.SaveDatosUser(userList);

            Carga();
            clear();
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            //ClsDDocentes user = new ClsDDocentes();
            //user.deleteDocente(Convert.ToInt32(txtIdDocente.Text));

            Carga();
            clear();
        }

        private void dgvDocente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String idDocente = dgvDocente.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dgvDocente.CurrentRow.Cells[1].Value.ToString();
            String apellido = dgvDocente.CurrentRow.Cells[2].Value.ToString();
            String dui = dgvDocente.CurrentRow.Cells[3].Value.ToString();
            String nacimiento = dgvDocente.CurrentRow.Cells[4].Value.ToString();
            //String nacimiento = dgvAlumnos.CurrentRow.Cells[5].Value.ToString();
            String direecion = dgvDocente.CurrentRow.Cells[5].Value.ToString();
            String email = dgvDocente.CurrentRow.Cells[6].Value.ToString();
            String telefono = dgvDocente.CurrentRow.Cells[7].Value.ToString();
            String registro = dgvDocente.CurrentRow.Cells[8].Value.ToString();

            txtIdDocente.Text = idDocente;
            txtNombreDocente.Text = Nombre;
            txtApellidoDocente.Text = apellido;
            txtDui.Text = dui;
            dtpFecha.Value = default;
            txtDireccion.Text = direecion;
            txtEmail.Text = email;
            txtTelefono.Text = telefono;

        }

        private void dgvDocente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String idDocente = dgvDocente.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dgvDocente.CurrentRow.Cells[1].Value.ToString();
            String apellido = dgvDocente.CurrentRow.Cells[2].Value.ToString();
            String dui = dgvDocente.CurrentRow.Cells[3].Value.ToString();
            String nacimiento = dgvDocente.CurrentRow.Cells[4].Value.ToString();
            //String nacimiento = dgvAlumnos.CurrentRow.Cells[5].Value.ToString();
            String direecion = dgvDocente.CurrentRow.Cells[5].Value.ToString();
            String email = dgvDocente.CurrentRow.Cells[6].Value.ToString();
            String telefono = dgvDocente.CurrentRow.Cells[7].Value.ToString();
            String registro = dgvDocente.CurrentRow.Cells[8].Value.ToString();

            txtIdDocente.Text = idDocente;
            txtNombreDocente.Text = Nombre;
            txtApellidoDocente.Text = apellido;
            txtDui.Text = dui;
            dtpFecha.Value = default;
            txtDireccion.Text = direecion;
            txtEmail.Text = email;
            txtTelefono.Text = telefono;

        }
    }
}
