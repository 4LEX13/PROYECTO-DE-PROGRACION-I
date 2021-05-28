using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.MODEL;
using ProyectoFinal.DAO;
namespace ProyectoFinal.VISTA
{
    public partial class FrmAlumosMenuPrincipal : Form
    {
        public FrmAlumosMenuPrincipal()
        {
            InitializeComponent();
            Carga();
            clear();
        }
        void clear()
        {

            txtIdAlumos.Clear();
            txtNombreAlumno.Clear();
            txtApellidoPaterno.Clear();
            txtDireccion.Clear();
            txtRepresentante.Clear();
            txtContacto.Clear();
            txtCorreo.Clear();
           dtpFecha.Value = DateTime.Now.Date;

        }

        void Carga()
        {

            //dgvAlumnos.Rows.Clear();
            //using (GestorEstudiantesEntities db = new GestorEstudiantesEntities())
            //{
            //    var Lista = db.Alumnos.ToList();

            //    foreach (var iteracion in Lista)
            //    {
            //        dgvAlumnos.Rows.Add(iteracion.alumnoid, iteracion.nombre, iteracion.Apellidos,iteracion.dirreccion,iteracion.representante,iteracion.contacto1,iteracion.nacimiento,iteracion.correo);
            //    }
            //}

        }

 

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //ClsDAlumnos clsDUserList = new ClsDAlumnos();
            //Alumnos userList = new Alumnos();
            //userList.nombre = txtNombreAlumno.Text;
            //userList.Apellidos = txtApellidoAlumno.Text;
            //userList.dirreccion = txtDireccion.Text;
            //userList.representante = txtRepresentante.Text;
            //userList.nacimiento = dtpFecha.Value;
            //userList.contacto1 = txtContacto.Text;
            //userList.correo = txtCorreo.Text;

            //clsDUserList.SaveDatosUser(userList);

            Carga();
            clear();
        }

        private void btnRegistarAlumnos_Click_1(object sender, EventArgs e)
        {
            //ClsDAlumnos clsDUserList = new ClsDAlumnos();
            //Alumnos userList = new Alumnos();
            //userList.nombre = txtNombreAlumno.Text;
            //userList.Apellidos = txtApellidoAlumno.Text;
            //userList.dirreccion = txtDireccion.Text;
            //userList.representante = txtRepresentante.Text;
            //userList.nacimiento = dtpFecha.Value;
            //userList.contacto1 = txtContacto.Text;
            //userList.correo = txtCorreo.Text;

            //clsDUserList.SaveDatosUser(userList);

            Carga();
            clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //ClsDAlumnos user = new ClsDAlumnos();
            //user.deleteAlumno(Convert.ToInt32(txtIdAlumos.Text));

            Carga();
            clear();
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String idAlumnos = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
            String nombre = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
            String direccion = dgvAlumnos.CurrentRow.Cells[3].Value.ToString();
            String representante = dgvAlumnos.CurrentRow.Cells[4].Value.ToString();
            //String nacimiento = dgvAlumnos.CurrentRow.Cells[5].Value.ToString();
            String contacto = dgvAlumnos.CurrentRow.Cells[5].Value.ToString();
            String correo = dgvAlumnos.CurrentRow.Cells[6].Value.ToString();


            txtIdAlumos.Text = idAlumnos;
            txtNombreAlumno.Text = nombre;
            txtApellidoPaterno.Text = Apellido;
            txtDireccion.Text = direccion;
            txtRepresentante.Text = representante;
            //dtpFecha.Value = default;
            txtContacto.Text = contacto;
            txtCorreo.Text = correo;

           
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String idAlumnos = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
            String nombre = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
            String direccion = dgvAlumnos.CurrentRow.Cells[3].Value.ToString();
            String representante = dgvAlumnos.CurrentRow.Cells[4].Value.ToString();
            //String nacimiento = dgvAlumnos.CurrentRow.Cells[5].Value.ToString();
            String contacto = dgvAlumnos.CurrentRow.Cells[5].Value.ToString();
            String correo = dgvAlumnos.CurrentRow.Cells[6].Value.ToString();


            txtIdAlumos.Text = idAlumnos;
            txtNombreAlumno.Text = nombre;
            txtApellidoPaterno.Text = Apellido;
            txtDireccion.Text = direccion;
            txtRepresentante.Text = representante;
            txtContacto.Text = contacto;
            txtCorreo.Text = correo;

       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscarA_Click(object sender, EventArgs e)
        {

        }
    }
}