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
        

        public FrmMatricula()
        {
            InitializeComponent();
            Carga();
            clear();
        }

        void clear()
        {

            txtIdMatricula.Clear();
            txtFkAlumno.Clear();
            txtAlumno.Clear();
            txtAlumno.Clear();
            txtAlumno.Clear();
            txtFkGrado.Clear();
            txtNombreMatricula.Clear();
            txtFkSeccion.Clear();
            dtpRegistroFecha.Value = DateTime.Now.Date;
            // cbxGrado.
            //cbxSeccion.

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

        private void FrmMatricula_Load(object sender, EventArgs e)
        {
            try
            {
                ClsDGrado grados = new ClsDGrado();
                ClsDSeccion secciones = new ClsDSeccion();

                cbxGrado.DataSource = grados.cargarGrados();
                cbxGrado.DisplayMember = "nombreGrado";
                cbxGrado.ValueMember = "gradoId";

                cbxSeccion.DataSource = secciones.cargarSeccion();
                cbxSeccion.DisplayMember = "nombreSeccion";
                cbxSeccion.ValueMember = "seccionId";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de tipo "+ ex);
            }
            

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClsDMatricula matricula = new ClsDMatricula();
            Matricula guardarMatricula = new Matricula();

            guardarMatricula.alumnoFk = Convert.ToInt32(txtFkAlumno.Text);
            guardarMatricula.gradoFk = Convert.ToInt32(cbxGrado.SelectedValue.ToString());
            guardarMatricula.seccionFk = Convert.ToInt32(cbxSeccion.SelectedValue.ToString());
            guardarMatricula.nombreMatricula = txtNombreMatricula.Text;
            guardarMatricula.fechaRegistroMatricula = DateTime.Now.Date;

            matricula.guardarMatricula(guardarMatricula);

            Carga();
            //clear();
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            FrmExtraerAlumno buscar = new FrmExtraerAlumno();
            buscar.ShowDialog();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Carga();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDMatricula matricula = new ClsDMatricula();
                Matricula modificarMatricula = new Matricula();

                modificarMatricula.matriculaId = (Convert.ToInt32(txtIdMatricula.Text));
                modificarMatricula.alumnoFk = (Convert.ToInt32(txtFkAlumno.Text));
                modificarMatricula.gradoFk = Convert.ToInt32(cbxGrado.SelectedValue.ToString());
                modificarMatricula.seccionFk = Convert.ToInt32(cbxSeccion.SelectedValue.ToString());
                modificarMatricula.nombreMatricula = txtNombreMatricula.Text;



                matricula.modificarMatricula(modificarMatricula);


                Carga();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDMatricula matricula = new ClsDMatricula();
                matricula.eliminarMatricula(Convert.ToInt32(txtIdMatricula.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
            Carga();
            clear();
        }

        private void dtgMatricula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String idMatricula = dtgMatricula.CurrentRow.Cells[0].Value.ToString();
            String fkAlumno = dtgMatricula.CurrentRow.Cells[1].Value.ToString();
            String nombreAlumno = dtgMatricula.CurrentRow.Cells[2].Value.ToString();
            String apellidPaterno = dtgMatricula.CurrentRow.Cells[3].Value.ToString();
            String ApellidoMaterno = dtgMatricula.CurrentRow.Cells[4].Value.ToString();
            String fkGrado = dtgMatricula.CurrentRow.Cells[5].Value.ToString();
            String grado = dtgMatricula.CurrentRow.Cells[6].Value.ToString();
            String fKSeccion = dtgMatricula.CurrentRow.Cells[7].Value.ToString();
            String seccion = dtgMatricula.CurrentRow.Cells[8].Value.ToString();
            String nombreMatricula = dtgMatricula.CurrentRow.Cells[9].Value.ToString();
            String fechaDeRegistro = dtgMatricula.CurrentRow.Cells[10].Value.ToString();




            txtIdMatricula.Text = idMatricula;
            txtFkAlumno.Text = fkAlumno;
            txtAlumno.Text = txtAlumno.Text = nombreAlumno + " " + apellidPaterno + " " + ApellidoMaterno;
            txtFkGrado.Text = fkGrado;
            cbxGrado.Text = grado;
            txtFkSeccion.Text = fKSeccion;
            cbxSeccion.Text = seccion;
            txtNombreMatricula.Text = nombreMatricula;
            dtpRegistroFecha.Text = fechaDeRegistro;

        }
    }
}
