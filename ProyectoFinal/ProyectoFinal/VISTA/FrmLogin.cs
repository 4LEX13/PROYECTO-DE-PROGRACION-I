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
    public partial class FrmLogin : Form
    {
        string user = "";
        string pass = "";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"E.png");
            pictureBox1.Image = image;

           
        }

      

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            String user = txtUsuario.Text;
            String pass = txtPass.Text;

            using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
            {
                var lg = from login in db.Usuario
                         where login.correo_Usuario == txtUsuario.Text && login.contrasena == txtPass.Text
                         select login;

                if (lg.Count() > 0)
                {
                    MessageBox.Show("Bienvenido" + user);
                    FrmMenu menu = new FrmMenu();
                    menu.Show();
                    menu.FormClosed += CerrarSesion;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Password Incorrecta");
                }
            }




            /*ClsDLoginUser clsDLog = new ClsDLoginUser();

            List<Usuarios> Login = clsDLog.loginUser();

            String user = txtUsuario.Text;
            String pass = txtPass.Text;

            foreach (var usuarios in Login)
            {


                if (user == usuarios.Nombre_User && pass == usuarios.Pass)
                {

                    FrmMenu menu = new FrmMenu();
                    MessageBox.Show("Bienvenido");
                    menu.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o Password Incorrecta");
                }*/


        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text =="Usuario"){
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;

            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {

            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;

            }
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = "Contraseña";
            txtPass.UseSystemPasswordChar = false;
            txtUsuario.Text = "Usuario";
            txtPass.ForeColor = Color.DimGray;
            txtUsuario.ForeColor = Color.DimGray;

            this.Show();
        }

        private void lblCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmCrearCuenta crearCuenta = new FrmCrearCuenta();

            crearCuenta.Show();
        }
    }
}
