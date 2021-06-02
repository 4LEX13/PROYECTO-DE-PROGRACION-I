using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.DAO;
using ProyectoFinal.MODEL;

namespace ProyectoFinal.VISTA
{
    public partial class FrmMatricula : Form
    {
        ClsDGrado grados = new ClsDGrado();
        ClsDSeccion secciones = new ClsDSeccion();

        public FrmMatricula()
        {
            InitializeComponent();
            Carga();
        }

        //void clear()
        //{

        //    txtIdDocente.Clear();
        //    txtNombreDocente.Clear();
        //    txtApellidoDocente.Clear();
        //    txtDui.Clear();
        //    //cbxGenero.DataSource = null;
        //    //cbxGenero.Items.Clear();
        //    txtTelefono.Clear();
        //    txtEmail.Clear();
        //    dtpFecha.Value = DateTime.Now.Date;
        //    txtFkDireccion.Clear();
        //    txtRecidencia.Clear();
        //    txtMunicipio.Clear();
        //    txtDepartamento.Clear();

        //}
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
                             && matricula.seccionFk == seccion.seccionId) /*&& (maestro.nombre + " " + maestro.apellido).Contains(txtFiltro.Text)*/
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

        //public String fkgrado;
        //public String fkseccion;
        private void FrmMatricula_Load(object sender, EventArgs e)
        {
            cbxGrado.DataSource = grados.cargarGrados();
            cbxGrado.DisplayMember = "nombreGrado";
            cbxGrado.ValueMember = "gradoId";

            cbxSeccion.DataSource = secciones.cargarSeccion();
            cbxSeccion.DisplayMember = "nombreSeccion";
            cbxSeccion.ValueMember = "seccionId";
          
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClsDMatricula matricula = new ClsDMatricula();
            Matricula guardarMatricula = new Matricula();

            guardarMatricula.alumnoFk = Convert.ToInt32(txtFkAlumno.Text);
            guardarMatricula.gradoFk = Convert.ToInt32(++cbxGrado.SelectedIndex);
            guardarMatricula.seccionFk = Convert.ToInt32(++cbxSeccion.SelectedIndex);
            guardarMatricula.nombreMatricula = txtNombreMatricula.Text;
            guardarMatricula.fechaRegistroMatricula = DateTime.Now.Date;

            matricula.guardarMatricula(guardarMatricula);

            Carga();
            //clear();
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            FrmBuscarAlumno buscar = new FrmBuscarAlumno();
            buscar.ShowDialog();
        }
    }
}
