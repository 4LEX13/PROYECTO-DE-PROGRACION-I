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
            txtDui.Clear();
            txtGenero.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            dtpFecha.Value = DateTime.Now.Date;

        }

        void Carga()
        {

            dgvDocente.Rows.Clear();
            using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
            {
                var Lista = db.Maestro.ToList();

                foreach (var listadoMaestro in Lista)
                {
                    dgvDocente.Rows.Add(listadoMaestro.maestroId, listadoMaestro.nombre, listadoMaestro.apellido, listadoMaestro.identificacion, listadoMaestro.genero , listadoMaestro.fechaNacimiento,  listadoMaestro.contacto, listadoMaestro.correo, listadoMaestro.activo, listadoMaestro.fechaRegistro);
                }
            }
        }


     

        private void btnRegistarDocente_Click(object sender, EventArgs e)
        {

            ClsDDocentes clsDUserList = new ClsDDocentes();
            Maestro MaestroRegistrar = new Maestro();
            MaestroRegistrar.nombre = txtNombreDocente.Text;
            MaestroRegistrar.apellido = txtApellidoDocente.Text;
            MaestroRegistrar.identificacion = txtDui.Text;
            MaestroRegistrar.genero = txtGenero.Text;
            MaestroRegistrar.fechaNacimiento = dtpFecha.Value;
            MaestroRegistrar.correo = txtEmail.Text;
            MaestroRegistrar.contacto = txtTelefono.Text;
            MaestroRegistrar.activo = rvSi.Checked == true ? 1 : 2;

            clsDUserList.SaveDatosUser(MaestroRegistrar);

            Carga();
            clear();

        }

        private void btnModificarDocente_Click(object sender, EventArgs e)
        {
            ClsDDocentes clsDUserList = new ClsDDocentes();
            Maestro maestroUpdate = new Maestro();
            maestroUpdate.nombre = txtNombreDocente.Text;
            maestroUpdate.apellido = txtApellidoDocente.Text;
            maestroUpdate.identificacion = txtDui.Text;
            maestroUpdate.genero = txtGenero.Text;
            maestroUpdate.fechaNacimiento = dtpFecha.Value;
            maestroUpdate.correo = txtEmail.Text;
            maestroUpdate.contacto = txtTelefono.Text;
            maestroUpdate.activo = rvSi.Checked == true ? 1 : 2;

            clsDUserList.SaveDatosUser(maestroUpdate);

            Carga();
            clear();
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            ClsDDocentes user = new ClsDDocentes();
            user.deleteDocente(Convert.ToInt32(txtIdDocente.Text));

            Carga();
            clear();
        }

        private void dgvDocente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String idDocente = dgvDocente.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dgvDocente.CurrentRow.Cells[1].Value.ToString();
            String apellido = dgvDocente.CurrentRow.Cells[2].Value.ToString();
            String dui = dgvDocente.CurrentRow.Cells[3].Value.ToString();
            String genero = dgvDocente.CurrentRow.Cells[4].Value.ToString();
            String nacimiento = dgvDocente.CurrentRow.Cells[5].Value.ToString();
            String email = dgvDocente.CurrentRow.Cells[6].Value.ToString();
            String telefono = dgvDocente.CurrentRow.Cells[7].Value.ToString();
            //string activo = dgvDocente.CurrentRow.Cells[8].Value.ToString();
           


            txtIdDocente.Text = idDocente;
            txtNombreDocente.Text = Nombre;
            txtApellidoDocente.Text = apellido;
            txtDui.Text = dui;
            txtGenero.Text = genero;
            dtpFecha.Text = nacimiento;      
            txtEmail.Text = email;
            txtTelefono.Text = telefono;
             

        }

        private void dgvDocente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String idDocente = dgvDocente.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dgvDocente.CurrentRow.Cells[1].Value.ToString();
            String apellido = dgvDocente.CurrentRow.Cells[2].Value.ToString();
            String dui = dgvDocente.CurrentRow.Cells[3].Value.ToString();
            String genero = dgvDocente.CurrentRow.Cells[4].Value.ToString();
            String nacimiento = dgvDocente.CurrentRow.Cells[5].Value.ToString();
            String email = dgvDocente.CurrentRow.Cells[6].Value.ToString();
            String telefono = dgvDocente.CurrentRow.Cells[7].Value.ToString();
            //string activo = dgvDocente.CurrentRow.Cells[8].Value.ToString();


            txtIdDocente.Text = idDocente;
            txtNombreDocente.Text = Nombre;
            txtApellidoDocente.Text = apellido;
            txtDui.Text = dui;
            txtGenero.Text = genero;
            dtpFecha.Text = nacimiento;
            txtEmail.Text = email;
            txtTelefono.Text = telefono;
        }
    }
}
