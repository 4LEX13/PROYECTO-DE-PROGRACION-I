using ProyectoFinal_P1.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdminsitrador_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"A.png");
            pictureBox1.Image = image;

            Image image2 = Image.FromFile(@"P.png");
            pictureBox2.Image = image2;
        }
    }
}
