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
    public partial class FrmBuscarDocente : Form
    {
        public FrmBuscarDocente()
        {
            InitializeComponent();
            Carga();
        }
        void Carga()
        {

            dgvDocente.Rows.Clear();
            using (AdministracionEscolarEntities bd = new AdministracionEscolarEntities())
            {
                var Lista = (from maestro in bd.Maestro
                             from direccion in bd.Direccion
                             where maestro.direccionFk == direccion.direccionId && (maestro.nombre + " "+ maestro.apellido).Contains(txtFiltro.Text)
                             select new
                             {
                                 maestro.maestroId,
                                 maestro.nombre,
                                 maestro.apellido,
                                 maestro.identificacion,
                                 maestro.genero,
                                 maestro.fechaNacimiento,
                                 direccion.direccionId,
                                 direccion.residencia,
                                 direccion.municipio,
                                 direccion.departamento,
                                 maestro.contacto,
                                 maestro.correo,
                                 maestro.activo,
                                 maestro.fechaRegistro


                             }).ToList();


                foreach (var listadoMaestro in Lista)
                {
                    dgvDocente.Rows.Add(listadoMaestro.maestroId, listadoMaestro.nombre, listadoMaestro.apellido,
                        listadoMaestro.identificacion, listadoMaestro.genero, listadoMaestro.fechaNacimiento, listadoMaestro.direccionId, listadoMaestro.residencia,
                        listadoMaestro.municipio, listadoMaestro.departamento, listadoMaestro.contacto,
                        listadoMaestro.correo, listadoMaestro.activo, listadoMaestro.fechaRegistro);
                }
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Carga();
        }

        private void FrmBuscarDocente_Load(object sender, EventArgs e)
        {
            txtFiltro.Focus();
        }
    }
}
