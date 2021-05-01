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
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"E.png");
            pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String user = txtUsuario.Text;
            String pass = txtPass.Text;

            using (GestorEstudiantesEntities db = new GestorEstudiantesEntities())
            {
                var lg = from login in db.Usuarios
                         where login.Nombre_User == txtUsuario.Text && login.Pass == txtPass.Text
                         select login;

                if (lg.Count() > 0)
                {
                    MessageBox.Show("BIENVENIDO");
                    FrmMenu menu = new FrmMenu();
                    menu.Show();
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


        
    }
}
