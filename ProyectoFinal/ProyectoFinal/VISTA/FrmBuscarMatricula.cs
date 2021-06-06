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
    public partial class FrmBuscarMatricula : Form
    {
        public FrmBuscarMatricula()
        {
            InitializeComponent();
            Carga();
        }
        void Carga()
        {

            dtgMatricula.Rows.Clear();
            using (AdministracionEscolarEntities bd = new AdministracionEscolarEntities())
            {
                var Lista = (from matricula in bd.Matricula
                             from alumno in bd.Alumno
                             from grado in bd.Grado
                             from seccion in bd.Seccion
                             where (matricula.alumnoFk == alumno.alumnoId && matricula.gradoFk == grado.gradoId
                             && matricula.seccionFk == seccion.seccionId) && (alumno.nombre + " " + alumno.apellidoPaterno + " " + alumno.apellidoMaterno).Contains(txtFiltro.Text)
                             select new
                             {
                                 matricula.matriculaId,
                                 matricula.alumnoFk,
                                 alumno.nombre,
                                 alumno.apellidoPaterno,
                                 alumno.apellidoMaterno,
                                 matricula.gradoFk,
                                 grado.nombreGrado,
                                 matricula.seccionFk,
                                 seccion.nombreSeccion,
                                 matricula.nombreMatricula,
                                 matricula.fechaRegistroMatricula



                             }).ToList();


                foreach (var listadoMatricula in Lista)
                {
                    dtgMatricula.Rows.Add(listadoMatricula.matriculaId, listadoMatricula.alumnoFk, listadoMatricula.nombre,
                                          listadoMatricula.apellidoPaterno, listadoMatricula.apellidoMaterno, listadoMatricula.gradoFk,
                                          listadoMatricula.nombreGrado, listadoMatricula.seccionFk, listadoMatricula.nombreSeccion,
                                          listadoMatricula.nombreMatricula, listadoMatricula.fechaRegistroMatricula);
                }
            }
        }

        private void FrmClassroom_Load(object sender, EventArgs e)
        {
            txtFiltro.Focus();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Carga();
        }
    }
}
