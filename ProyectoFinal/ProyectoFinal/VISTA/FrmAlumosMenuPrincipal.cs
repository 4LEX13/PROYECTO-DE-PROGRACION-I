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
            txtApellidoAlumno.Clear();

        }

        void Carga()
        {

            dataGridView1.Rows.Clear();
            using (GestorEstudiantesEntities db = new GestorEstudiantesEntities())
            {
                var Lista = db.Alumnos.ToList();

                foreach (var iteracion in Lista)
                {
                    dataGridView1.Rows.Add(iteracion.alumnoid, iteracion.nombre, iteracion.Apellidos);
                }
            }

        }

        private void btnRegistarAlumnos_Click(object sender, EventArgs e)
        {
            ClsDAlumnos clsDUserList = new ClsDAlumnos();
            Alumnos userList = new Alumnos();
            userList.nombre = txtNombreAlumno.Text;
            userList.Apellidos = txtApellidoAlumno.Text;


            clsDUserList.SaveDatosUser(userList);

            Carga();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String idAlumnos = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dataGridView1.CurrentRow.Cells[2].Value.ToString();



            txtIdAlumos.Text = idAlumnos;
            txtNombreAlumno.Text = nombre;
            txtApellidoAlumno.Text = Apellido;

        }
    }
}