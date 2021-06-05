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
    public partial class FrmCrearCuenta : Form
    {
        public FrmCrearCuenta()
        {
            InitializeComponent();
            Carga();
            clear();

        }
        void clear()
        {

            txtCorreoCuenta.Clear();
            txtPassCuenta.Clear();
           

        }


        void Carga()
        {
            dgvRegistrarCuenta.Rows.Clear();
            using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
            {
                var Lista = db.Usuario.ToList();

                foreach (var iteracion in Lista)
                {
                    dgvRegistrarCuenta.Rows.Add(iteracion.usuarioId, iteracion.correo_Usuario, iteracion.contrasena);
                }
            }
        }


        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {

            ClsDCrearCuenta cuenta = new ClsDCrearCuenta();
            Usuario crearUsuario = new Usuario();


            crearUsuario.correo_Usuario = txtCorreoCuenta.Text;
            crearUsuario.contrasena = txtPassCuenta.Text;

            cuenta.GuardarCuenta (crearUsuario);

            Carga();
            clear();
        }





    }
}
