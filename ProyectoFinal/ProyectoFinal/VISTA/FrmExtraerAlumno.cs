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

namespace ProyectoFinal.VISTA
{
    public partial class FrmExtraerAlumno : Form
    {
        public FrmExtraerAlumno()
        {
            InitializeComponent();
            Carga();
        }
        void Carga()
        {

            dtgAlumnoBuscar.Rows.Clear();
            using (AdministracionEscolarEntities bd = new AdministracionEscolarEntities())
            {
                var Lista = (from alumno in bd.Alumno
                             from direccion in bd.Direccion
                             from encargado in bd.Encargado
                             where (alumno.direccionFk == direccion.direccionId && alumno.encargadoFK == encargado.encargadoId) && (alumno.nombre + " " + alumno.apellidoPaterno + " " + alumno.apellidoMaterno).Contains(txtFiltro.Text)
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
                    dtgAlumnoBuscar.Rows.Add(listadoAlumno.alumnoId, listadoAlumno.nombre, listadoAlumno.apellidoPaterno, listadoAlumno.apellidoMaterno,
                        listadoAlumno.genero, listadoAlumno.fechaNacimiento, listadoAlumno.direccionFk, listadoAlumno.residencia,
                        listadoAlumno.municipio, listadoAlumno.departamento, listadoAlumno.contacto,
                        listadoAlumno.correo, listadoAlumno.activo, listadoAlumno.fechaRegistro, listadoAlumno.encargadoFK, listadoAlumno.nombreEncargado,
                        listadoAlumno.apellidoEncargado, listadoAlumno.identificacionEncargado, listadoAlumno.contactoEncargado, listadoAlumno.correoEncargado);


                }
            }
        }
        void envio()
        {
            String id = dtgAlumnoBuscar.CurrentRow.Cells[0].Value.ToString();
            String nombre = dtgAlumnoBuscar.CurrentRow.Cells[1].Value.ToString();
            String apellidoPaterno = dtgAlumnoBuscar.CurrentRow.Cells[2].Value.ToString();
            String apellidoMaterno = dtgAlumnoBuscar.CurrentRow.Cells[3].Value.ToString();


            FrmMPrincipal.matriculaVer.txtFkAlumno.Text = id;
            FrmMPrincipal.matriculaVer.txtAlumno.Text = nombre + " " + apellidoPaterno + " " + apellidoMaterno;

            this.Close();
        }

        private void dgvAlumno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            envio();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Carga();
        }
    }
}
