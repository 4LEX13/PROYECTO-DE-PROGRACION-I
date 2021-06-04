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
            ultimoDireccion();
            //ultimoAlumno();
        }



        void ultimoDireccion()
        {

            var consultarultimoDireccion = new ClsDDireccion();
            int lista = 0;

            foreach (var list in consultarultimoDireccion.cargarDireccion())
            {
                lista = list.direccionId;
            }



            lista++;
            txtFkDireccion.Text = lista.ToString();

        }

        //void ultimoAlumno()
        //{

        //    var consultarultimoalumno = new ClsDAlumnos();
        //    int lista = 0;

        //    foreach (var list in consultarultimoalumno.cargarAlumno())
        //    {
        //        lista = list.alumnoId;
        //    }



        //    lista++;
        //    txtFkAlumno.Text = lista.ToString();

        //}
        void clear()
        {

            txtIdAlumos.Clear();
            txtNombreAlumno.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            cbxGenero.Text = "Sin especificar";
            txtContacto.Clear();
            txtCorreo.Clear();
            dtpFecha.Value = DateTime.Now.Date;
            txtRecidencia.Clear();
            txtMunicipio.Clear();
            txtDepartamento.Clear();
            txtNombreEncargado.Clear();
            txtApellidoEncargado.Clear();
            txtDuiEncargado.Clear();
            txtCorreoEncargado.Clear();
            txtContactoEncargado.Clear();
            txtFkEncargado.Clear();
            txtFkDireccion.Clear();
            txtiDDireccion.Clear();
        }

        void Carga()
        {

            dgvAlumno.Rows.Clear();
            using (AdministracionEscolarEntities bd = new AdministracionEscolarEntities())
            {
                var Lista = (from alumno in bd.Alumno
                             from direccion in bd.Direccion from encargado in bd.Encargado
                             where (alumno.direccionFk == direccion.direccionId && alumno.encargadoFK==encargado.encargadoId ) && (alumno.nombre + " " + alumno.apellidoPaterno + " " + alumno.apellidoMaterno).Contains(txtFiltrarAlumnos.Text)
                             select new
                             {
                                 alumno.alumnoId,
                                 alumno.nombre,
                                 alumno.apellidoPaterno,
                                 alumno.apellidoMaterno,
                                 alumno.genero,
                                 alumno.fechaNacimiento,
                                 alumno.direccionFk,
                                 direccion.residencia,
                                 direccion.municipio,
                                 direccion.departamento,
                                 alumno.contacto,
                                 alumno.correo,
                                 alumno.activo,
                                 alumno.fechaRegistro,
                                 alumno.encargadoFK,
                                 encargado.nombreEncargado,
                                 encargado.apellidoEncargado,
                                 encargado.identificacionEncargado,
                                 encargado.contactoEncargado,
                                 encargado.correoEncargado


                             }).ToList();


                foreach (var listadoAlumno in Lista)
                {
                    dgvAlumno.Rows.Add(listadoAlumno.alumnoId, listadoAlumno.nombre, listadoAlumno.apellidoPaterno, listadoAlumno.apellidoMaterno,
                        listadoAlumno.genero, listadoAlumno.fechaNacimiento, listadoAlumno.direccionFk, listadoAlumno.residencia,
                        listadoAlumno.municipio, listadoAlumno.departamento, listadoAlumno.contacto,
                        listadoAlumno.correo, listadoAlumno.activo, listadoAlumno.fechaRegistro,listadoAlumno.encargadoFK,listadoAlumno.nombreEncargado, 
                        listadoAlumno.apellidoEncargado,listadoAlumno.identificacionEncargado, listadoAlumno.contactoEncargado, listadoAlumno.correoEncargado);


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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDAlumnos user = new ClsDAlumnos();
            user.deleteAlumno(Convert.ToInt32(txtIdAlumos.Text));

            Carga();
            clear();
            ultimoDireccion();
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
            cbxGenero.Text = genero;
            dtpFecha.Text = nacimiento;
            txtiDDireccion.Text = idDireccion;
            txtRecidencia.Text = recidencia;
            txtMunicipio.Text = municipio;
            txtDepartamento.Text = departamento;
            txtContacto.Text = telefono;
            txtCorreo.Text = email;
            txtFkEncargado.Text = fkAlumno;
            txtNombreEncargado.Text = NombreEncargado;
            txtApellidoEncargado.Text = ApellidoEncargado;
            txtDuiEncargado.Text = DuiEncargado;
            txtContactoEncargado.Text = TelefonoEncargado;
            txtCorreoEncargado.Text = CorreoEncargado;



        }

        private void txtFiltrarAlumnos_TextChanged(object sender, EventArgs e)
        {
            Carga();
        }

        private void FrmAlumos_Load(object sender, EventArgs e)
        {
            cbxGenero.Text = "Sin especificar";
            //cbxGenero.Items.Add("Sin especificar");
            cbxGenero.Items.Add("Femenino");
            cbxGenero.Items.Add("Masculino");

        }

        private void btnRegistarAlumnos_Click(object sender, EventArgs e)
        {
            ClsDDireccion direccion = new ClsDDireccion();
            Direccion direccionRegistrar = new Direccion();

            ClsDEncargado encargado = new ClsDEncargado();
            Encargado registarencargado = new Encargado();

            ClsDAlumnos clsDAlumnos = new ClsDAlumnos();
            Alumno alumnoRegistrar = new Alumno();

            direccionRegistrar.residencia = txtRecidencia.Text;
            direccionRegistrar.municipio = txtMunicipio.Text;
            direccionRegistrar.departamento = txtDepartamento.Text;

            registarencargado.nombreEncargado = txtNombreEncargado.Text;
            registarencargado.apellidoEncargado = txtApellidoEncargado.Text;
            registarencargado.identificacionEncargado = txtDuiEncargado.Text;
            registarencargado.contactoEncargado = txtContactoEncargado.Text;
            registarencargado.correoEncargado = txtCorreoEncargado.Text;

            alumnoRegistrar.nombre = txtNombreAlumno.Text;
            alumnoRegistrar.apellidoPaterno = txtApellidoPaterno.Text;
            alumnoRegistrar.apellidoMaterno = txtApellidoMaterno.Text;
            alumnoRegistrar.genero = cbxGenero.Text;
            alumnoRegistrar.fechaNacimiento = dtpFecha.Value;
            alumnoRegistrar.direccionFk = Convert.ToInt32(txtFkDireccion.Text);
            alumnoRegistrar.contacto = txtContacto.Text;
            alumnoRegistrar.correo = txtCorreo.Text;
            alumnoRegistrar.activo = rbSi.Checked == true ? 1 : 2;
            alumnoRegistrar.fechaRegistro = DateTime.Now.Date;
            alumnoRegistrar.encargadoFK = Convert.ToInt32(txtFkEncargado.Text);


            direccion.SaveDireccion(direccionRegistrar);
            encargado.SaveEncargado(registarencargado);
            clsDAlumnos.SaveAlumno(alumnoRegistrar);
            

            Carga();
            clear();
            ultimoDireccion();

        }
    }
}