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
    public partial class FrmAlumos : Form
    {
        public FrmAlumos()
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
            txtApellidoMaterno.Clear();
            txtGenero.Clear();
            txtContacto.Clear();
            txtCorreo.Clear();
           dtpFecha.Value = DateTime.Now.Date;

        }

        void Carga()
        {

            dgvAlumno.Rows.Clear();
            using (AdministracionEscolarEntities bd = new AdministracionEscolarEntities())
            {
                var Lista = (from alumno in bd.Alumno
                             from direccion in bd.Direccion
                             where alumno.direccionFk == direccion.direccionId && (alumno.nombre + " " + alumno.apellidoPaterno + " " + alumno.apellidoMaterno).Contains(txtFiltrarAlumnos.Text)
                             select new
                             {
                                 alumno.alumnoId,
                                 alumno.nombre,
                                 alumno.apellidoPaterno,
                                 alumno.apellidoMaterno,
                                 alumno.genero,
                                 alumno.fechaNacimiento,
                                 direccion.direccionId,
                                 direccion.residencia,
                                 direccion.municipio,
                                 direccion.departamento,
                                 alumno.contacto,
                                 alumno.correo,
                                 alumno.activo,
                                 alumno.fechaRegistro


                             }).ToList();


                foreach (var listadoMaestro in Lista)
                {
                    dgvAlumno.Rows.Add(listadoMaestro.alumnoId, listadoMaestro.nombre, listadoMaestro.apellidoPaterno, listadoMaestro.apellidoMaterno,
                        listadoMaestro.genero, listadoMaestro.fechaNacimiento, listadoMaestro.direccionId, listadoMaestro.residencia,
                        listadoMaestro.municipio, listadoMaestro.departamento, listadoMaestro.contacto,
                        listadoMaestro.correo, listadoMaestro.activo, listadoMaestro.fechaRegistro);
                }
            }
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClsDDireccion direccion = new ClsDDireccion();
            Direccion direccionRegistrar = new Direccion();





            ClsDMaestro clsDUserList = new ClsDMaestro();
            Maestro maestroUpdate = new Maestro();




            //maestroUpdate.maestroId = (Convert.ToInt32(txtIdDocente.Text));
            //maestroUpdate.nombre = txtNombreDocente.Text;
            //maestroUpdate.apellido = txtApellidoDocente.Text;
            //maestroUpdate.identificacion = txtDui.Text;
            //maestroUpdate.genero = cbxGenero.Text;
            //maestroUpdate.fechaNacimiento = dtpFecha.Value;
            //maestroUpdate.direccionFk = Convert.ToInt32(txtFkDireccion.Text);
            //direccionRegistrar.direccionId = (Convert.ToInt32(txtIdDireccion.Text));
            //direccionRegistrar.residencia = txtRecidencia.Text;
            //direccionRegistrar.municipio = txtMunicipio.Text;
            //direccionRegistrar.departamento = txtDepartamento.Text;
            //maestroUpdate.correo = txtEmail.Text;
            //maestroUpdate.contacto = txtTelefono.Text;
            //maestroUpdate.activo = rbSi.Checked == true ? 1 : 2;
            //maestroUpdate.fechaRegistro = dtpFechaDeRegistro.Value;

            //direccion.ModificarDireccion(direccionRegistrar);
            //clsDUserList.ModificarDocente(maestroUpdate);

            //Carga();
            //clear();
        }

        private void btnRegistarAlumnos_Click_1(object sender, EventArgs e)
        {
            //ClsDDireccion direccion = new ClsDDireccion();
            //Direccion direccionRegistrar = new Direccion();



            //ClsDMaestro clsDUserList = new ClsDMaestro();
            //Maestro maestroRegistrar = new Maestro();

            //direccionRegistrar.residencia = txtRecidencia.Text;
            //direccionRegistrar.municipio = txtMunicipio.Text;
            //direccionRegistrar.departamento = txtDepartamento.Text;

            //maestroRegistrar.nombre = txtNombreDocente.Text;
            //maestroRegistrar.apellido = txtApellidoDocente.Text;
            //maestroRegistrar.identificacion = txtDui.Text;
            //maestroRegistrar.genero = cbxGenero.Text;
            //maestroRegistrar.fechaNacimiento = dtpFecha.Value;
            //maestroRegistrar.direccionFk = Convert.ToInt32(txtFkDireccion.Text);
            //maestroRegistrar.contacto = txtTelefono.Text;
            //maestroRegistrar.correo = txtEmail.Text;
            //maestroRegistrar.activo = rbSi.Checked == true ? 1 : 2;
            //maestroRegistrar.fechaRegistro = DateTime.Now.Date;

            //direccion.SaveDireccion(direccionRegistrar);
            //clsDUserList.SaveDatosUser(maestroRegistrar);


            //Carga();
            //clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDAlumnos user = new ClsDAlumnos();
            user.deleteAlumno(Convert.ToInt32(txtIdAlumos.Text));

            Carga();
            clear();
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String idAlumno = dgvAlumno.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dgvAlumno.CurrentRow.Cells[1].Value.ToString();
            String apellidoPaterno = dgvAlumno.CurrentRow.Cells[2].Value.ToString();
            String ApellidoMaterno = dgvAlumno.CurrentRow.Cells[3].Value.ToString();
            String genero = dgvAlumno.CurrentRow.Cells[4].Value.ToString();
            String nacimiento = dgvAlumno.CurrentRow.Cells[5].Value.ToString();
            string idDireccion = dgvAlumno.CurrentRow.Cells[6].Value.ToString();
            string recidencia = dgvAlumno.CurrentRow.Cells[7].Value.ToString();
            string municipio = dgvAlumno.CurrentRow.Cells[8].Value.ToString();
            string departamento = dgvAlumno.CurrentRow.Cells[9].Value.ToString();
            String telefono = dgvAlumno.CurrentRow.Cells[10].Value.ToString();
            String email = dgvAlumno.CurrentRow.Cells[11].Value.ToString();
            string activo = dgvAlumno.CurrentRow.Cells[12].Value.ToString();
            string fechaRegistro = dgvAlumno.CurrentRow.Cells[13].Value.ToString();
            string fkAlumno = dgvAlumno.CurrentRow.Cells[14].Value.ToString();
            string NombreEncargado = dgvAlumno.CurrentRow.Cells[15].Value.ToString();
            string ApellidoEncargado = dgvAlumno.CurrentRow.Cells[16].Value.ToString();
            string DuiEncargado = dgvAlumno.CurrentRow.Cells[17].Value.ToString();
            string TelefonoEncargado = dgvAlumno.CurrentRow.Cells[18].Value.ToString();
            string CorreoEncargado = dgvAlumno.CurrentRow.Cells[19].Value.ToString();



            txtIdAlumos.Text = idAlumno;
            txtNombreAlumno.Text = Nombre;
            txtApellidoPaterno.Text = apellidoPaterno;
            txtApellidoMaterno.Text = ApellidoMaterno;
            txtGenero.Text = genero;
            dtpFecha.Text = nacimiento;
            txtiDDireccion.Text = idDireccion;
            txtRecidencia.Text = recidencia;
            txtMunicipio.Text = municipio;
            txtDepartamento.Text = departamento;
            txtContacto.Text = telefono;
            txtCorreo.Text = email;
            txtFkAlumno.Text = fkAlumno;
            txtNombreAlumno.Text = NombreEncargado;
            txtApellidoEncargado.Text = ApellidoEncargado;
            txtDuiEncargado.Text = DuiEncargado;
            txtContactoEncargado.Text = TelefonoEncargado;
            txtCorreoEncargado.Text = CorreoEncargado;



        }

        private void txtFiltrarAlumnos_TextChanged(object sender, EventArgs e)
        {
            Carga();
        }
    }
}