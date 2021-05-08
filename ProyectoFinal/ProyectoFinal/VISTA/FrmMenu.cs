using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.VISTA
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lx, ly;
        int sw, sh;

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            BtnMaximizar.Visible = true;
            BtnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void btnNotas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmNotas>();

        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmHorarios>();

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmConfiguracion>();

        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmMPrincipal>();
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formula;
            formula = panelFormula.Controls.OfType<MiForm>().FirstOrDefault();
                                                                                     
            if (formula == null)
            {
                formula = new MiForm();
                formula.TopLevel = false;
                formula.FormBorderStyle = FormBorderStyle.None;
                formula.Dock = DockStyle.Fill;
                panelFormula.Controls.Add(formula);
                panelFormula.Tag = formula;
                formula.Show();
                formula.BringToFront();
                formula.FormClosed += new FormClosedEventHandler(CloseForms);
            }
          
            else
            {
                formula.BringToFront();
            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FrmMPrincipal"] == null)
                btnPrincipal.BackColor = Color.FromArgb(176, 196, 222);

            if (Application.OpenForms["FrmNotas"] == null)
                btnNotas.BackColor = Color.FromArgb(176, 196, 222);
            if (Application.OpenForms["FrmHorarios"] == null)
                btnHorarios.BackColor = Color.FromArgb(176, 196, 222);
            if (Application.OpenForms["FrmConfiguracion"] == null)
                btnSetting.BackColor = Color.FromArgb(176, 196, 222);

        }

      


        }

}
