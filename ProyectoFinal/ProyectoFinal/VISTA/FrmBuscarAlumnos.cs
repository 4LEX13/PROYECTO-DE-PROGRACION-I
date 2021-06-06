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
    public partial class FrmBuscarAlumnos : Form
    {
        public FrmBuscarAlumnos()
        {
            InitializeComponent();
            Carga();
        }
        void Carga()
        {

            dgvAlumno.Rows.Clear();
            using (AdministracionEscolarEntities bd = new AdministracionEscolarEntities())
            {
                var Lista = (from alumno in bd.Alumno
                             from direccion in bd.Direccion
                             from encargado in bd.Encargado
                             where (alumno.direccionFk == direccion.direccionId && alumno.encargadoFK == encargado.encargadoId) && (alumno.nombre + " " + alumno.apellidoPaterno + " " + alumno.apellidoMaterno).Contains(txtFiltrarAlumnos.Text)
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
                        listadoAlumno.correo, listadoAlumno.activo, listadoAlumno.fechaRegistro, listadoAlumno.encargadoFK, listadoAlumno.nombreEncargado,
                        listadoAlumno.apellidoEncargado, listadoAlumno.identificacionEncargado, listadoAlumno.contactoEncargado, listadoAlumno.correoEncargado);


                }
            }
        }

        private void txtFiltrarAlumnos_TextChanged(object sender, EventArgs e)
        {
            Carga();
        }

        private void FrmBuscarAlumnos_Load(object sender, EventArgs e)
        {
            txtFiltrarAlumnos.Focus();
        }
    }
}
