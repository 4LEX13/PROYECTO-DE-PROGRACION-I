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
            FrmAlumos alumno = new FrmAlumos();
            alumno.Show();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            FrmDocente docente = new FrmDocente();
            docente.Show();

        }


        private void btnCuenta_Click(object sender, EventArgs e)
        {
            FrmCrearCuenta cuenta = new FrmCrearCuenta();
            cuenta.Show();
        }

        public static FrmMatricula matriculaVer = new FrmMatricula();

        private void btnMatriculas_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMatricula matricula = new FrmMatricula();
                matriculaVer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de tipo " + ex);
            }
            
        }
    }
}

