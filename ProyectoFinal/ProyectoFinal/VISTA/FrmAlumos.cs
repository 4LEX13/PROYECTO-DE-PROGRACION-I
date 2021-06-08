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
            ultimoEncargado();
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

        void ultimoEncargado()
        {

            var consultarultimoalumno = new ClsDEncargado();
            int lista = 0;

            foreach (var list in consultarultimoalumno.cargarEncargado())
            {
                lista = list.encargadoId;
            }



            lista++;
            txtFkEncargado.Text = lista.ToString();

        }
        void clear()
        {

            txtIdAlumno.Clear();
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
            rbSi.Checked = false;
            rbNo.Checked = false;
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
            try
            {
                ClsDDireccion direccion = new ClsDDireccion();
                Direccion direccionModificar = new Direccion();


                ClsDEncargado encargado = new ClsDEncargado();
                Encargado encargadoModificar = new Encargado();

                ClsDAlumnos alumnos = new ClsDAlumnos();
                Alumno alumnoModificar = new Alumno();



                direccionModificar.direccionId = (Convert.ToInt32(txtiDDireccion.Text));
                direccionModificar.residencia = txtRecidencia.Text;
                direccionModificar.municipio = txtMunicipio.Text;
                direccionModificar.departamento = txtDepartamento.Text;

                encargadoModificar.encargadoId = Convert.ToInt32(txtFkEncargado.Text);
                encargadoModificar.nombreEncargado = txtNombreEncargado.Text;
                encargadoModificar.apellidoEncargado = txtApellidoEncargado.Text;
                encargadoModificar.identificacionEncargado = txtDuiEncargado.Text;
                encargadoModificar.contactoEncargado = txtContactoEncargado.Text;
                encargadoModificar.correoEncargado = txtCorreoEncargado.Text;

                alumnoModificar.alumnoId = Convert.ToInt32(txtAlumnoId.Text);
                alumnoModificar.nombre = txtNombreAlumno.Text;
                alumnoModificar.apellidoPaterno = txtApellidoPaterno.Text;
                alumnoModificar.apellidoMaterno = txtApellidoMaterno.Text;
                alumnoModificar.genero = cbxGenero.Text;
                alumnoModificar.fechaNacimiento = dtpFecha.Value;
                alumnoModificar.direccionFk = Convert.ToInt32(txtFkDireccion.Text);
                alumnoModificar.contacto = txtContacto.Text;
                alumnoModificar.correo = txtCorreo.Text;
                alumnoModificar.activo = rbSi.Checked == true ? 1 : 2;
                alumnoModificar.fechaRegistro = dtpFechaRegistro.Value;
                alumnoModificar.encargadoFK = Convert.ToInt32(txtFkEncargado.Text);

                direccion.ModificarDireccion(direccionModificar);
                encargado.modificarEncargado(encargadoModificar);
                alumnos.ModificarAlunmos(alumnoModificar);

        }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex);
            }


    Carga();
            clear();
            ultimoDireccion();
            ultimoEncargado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {           
            try
            {
                ClsDAlumnos alumnos = new ClsDAlumnos();
                ClsDDireccion direccion = new ClsDDireccion();
                ClsDEncargado encargado = new ClsDEncargado();

                alumnos.deleteAlumno(Convert.ToInt32(txtIdAlumno.Text));
                direccion.deleteDireccion(Convert.ToInt32(txtiDDireccion.Text));
                encargado.eliminarEncargado(Convert.ToInt32(txtFkEncargado.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            Carga();
            clear();
            ultimoDireccion();
            ultimoEncargado();
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


            txtAlumnoId.Text = idAlumno;
            txtIdAlumno.Text = idAlumno;
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



            if (activo == "1")
            {
                rbSi.Checked = true;
                rbNo.Checked = false;
            }
            else
            {
                rbSi.Checked = false;
                rbNo.Checked = true;
            }



        }

        private void txtFiltrarAlumnos_TextChanged(object sender, EventArgs e)
        {
            Carga();
        }

        private void FrmAlumos_Load(object sender, EventArgs e)
        {
            cbxGenero.Text = "Sin especificar";
            cbxGenero.Items.Add("Femenino");
            cbxGenero.Items.Add("Masculino");

        }

        private void btnRegistarAlumnos_Click(object sender, EventArgs e)
        {
            try {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }     
            
            Carga();
            clear();
            ultimoDireccion();
            ultimoEncargado();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
            ultimoDireccion();
            ultimoEncargado();
        }
    }
}