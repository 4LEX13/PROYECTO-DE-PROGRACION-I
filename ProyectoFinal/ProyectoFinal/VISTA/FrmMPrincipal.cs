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
    public partial class FrmMPrincipal : Form
    {
        public FrmMPrincipal()
        {
            InitializeComponent();
        }

        private void btmAlumos_Click(object sender, EventArgs e)
        {
            FrmAlumosMenuPrincipal alumno = new FrmAlumosMenuPrincipal();
            alumno.Show();
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            FrmAulas aulas = new FrmAulas();
            aulas.Show();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {

        }

        private void btnClassrom_Click(object sender, EventArgs e)
        {
            FrmClassroom classroom = new FrmClassroom();
            classroom.Show();
        }

    //private void AbrirFormulario<MiForm>() where MiForm : Form, new()
    //{
    //    Form formula;
    //    formula = panelMenuPrincial.Controls.OfType<MiForm>().FirstOrDefault();

    //    if (formula == null)
    //    {
    //        formula = new MiForm();
    //        formula.TopLevel = false;
    //        formula.FormBorderStyle = FormBorderStyle.None;
    //        formula.Dock = DockStyle.Fill;
    //        panelMenuPrincial.Controls.Add(formula);
    //        panelMenuPrincial.Tag = formula;
    //        formula.Show();
    //        formula.BringToFront();
    //    }

    //    else
    //    {
    //        formula.BringToFront();
}
}

