using ProyectoFinal.DAO;
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
    public partial class FrmDocente : Form
    {
        public FrmDocente()
        {
            InitializeComponent();
            Carga();
            clear();
            ultimoDireccion();
        }


        void ultimoDireccion()
        {

            var consultarultimoDireccion = new ClsDDireccion();
            int lista = 0;

            foreach (var list in consultarultimoDireccion.cargarDireccion())
            {
                lista = list.direccionId;
            }



            lista++;
            txtIdDireccion.Text = lista.ToString();

        }



        void Carga()
        {

            dgvDocente.Rows.Clear();
            using (AdministracionEscolarEntities bd = new AdministracionEscolarEntities())
            {
                var Lista = (from maestro in bd.Maestro
                                from direccion in bd.Direccion
                                where maestro.direccionFk == direccion.direccionId && (maestro.nombre + maestro.apellido).Contains(txtFiltro.Text)
                             select new
                                {
                                   maestro.maestroId, maestro.nombre,maestro.apellido,maestro.identificacion,maestro.genero,maestro.fechaNacimiento,direccion.direccionId,
                                    direccion.residencia,direccion.municipio,direccion.departamento,maestro.contacto,maestro.correo,maestro.activo,maestro.fechaRegistro

                                    
                                }).ToList();


                foreach (var listadoMaestro in Lista)
                {
                    dgvDocente.Rows.Add(listadoMaestro.maestroId, listadoMaestro.nombre, listadoMaestro.apellido,
                        listadoMaestro.identificacion, listadoMaestro.genero, listadoMaestro.fechaNacimiento,listadoMaestro.direccionId, listadoMaestro.residencia,
                        listadoMaestro.municipio,listadoMaestro.departamento, listadoMaestro.contacto,
                        listadoMaestro.correo, listadoMaestro.activo, listadoMaestro.fechaRegistro);
                }
            }
        }


        void clear()
        {

            txtIdDocente.Clear();
            txtNombreDocente.Clear();
            txtApellidoDocente.Clear();
            txtDui.Clear();
            txtGenero.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            dtpFecha.Value = DateTime.Now.Date;
            txtIdDireccion.Clear();
            txtRecidencia.Clear();
            txtMunicipio.Clear();
            txtDepartamento.Clear();

        }

        private void btnRegistarDocente_Click(object sender, EventArgs e)
        {
            ClsDDireccion direccion = new ClsDDireccion();
            Direccion direccionRegistrar = new Direccion();
           
           

            ClsDMaestro clsDUserList = new ClsDMaestro();
            Maestro maestroRegistrar = new Maestro();

            direccionRegistrar.residencia = txtRecidencia.Text;
            direccionRegistrar.municipio = txtMunicipio.Text;
            direccionRegistrar.departamento = txtDepartamento.Text;

            maestroRegistrar.nombre = txtNombreDocente.Text;
            maestroRegistrar.apellido = txtApellidoDocente.Text;
            maestroRegistrar.identificacion = txtDui.Text;
            maestroRegistrar.genero = txtGenero.Text;
            maestroRegistrar.fechaNacimiento = dtpFecha.Value;
            maestroRegistrar.direccionFk = Convert.ToInt32(txtIdDireccion.Text);
            maestroRegistrar.contacto = txtTelefono.Text;
            maestroRegistrar.correo = txtEmail.Text;
            maestroRegistrar.activo = rbSi.Checked == true ? 1 : 2;
            maestroRegistrar.fechaRegistro = DateTime.Now.Date;

            direccion.SaveDireccion(direccionRegistrar);
            clsDUserList.SaveDatosUser(maestroRegistrar);


            Carga();
            clear();

        }

        private void btnModificarDocente_Click(object sender, EventArgs e)
        {
            ClsDMaestro clsDUserList = new ClsDMaestro();
            Maestro maestroUpdate = new Maestro();



            ClsDDireccion direccion = new ClsDDireccion();
            Direccion direccionRegistrar = new Direccion();

            direccionRegistrar.direccionId = (Convert.ToInt32 (txtIdDireccion.Text));
            direccionRegistrar.residencia = txtRecidencia.Text;
            direccionRegistrar.municipio = txtMunicipio.Text;
            direccionRegistrar.departamento = txtDepartamento.Text;


            maestroUpdate.maestroId = (Convert.ToInt32 (txtIdDocente.Text));
            maestroUpdate.nombre = txtNombreDocente.Text;
            maestroUpdate.apellido = txtApellidoDocente.Text;
            maestroUpdate.identificacion = txtDui.Text;
            maestroUpdate.genero = txtGenero.Text;
            maestroUpdate.fechaNacimiento = dtpFecha.Value;
            maestroUpdate.direccionFk = Convert.ToInt32 (txtIdDireccion.Text);
            maestroUpdate.correo = txtEmail.Text;
            maestroUpdate.contacto = txtTelefono.Text;
            maestroUpdate.activo = rbSi.Checked == true ? 1 : 2;
            //maestroUpdate.fechaRegistro = DateTime.Now(fechaRegistro);

            direccion.ModificarDireccion(direccionRegistrar);
            clsDUserList.ModificarDocente(maestroUpdate);

            Carga();
            clear();
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            ClsDMaestro user = new ClsDMaestro();
            user.deleteDocente(Convert.ToInt32(txtIdDocente.Text));

            
            Carga();
            clear();
        }

        public string fechaRegistro;
        private void dgvDocente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String idDocente = dgvDocente.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dgvDocente.CurrentRow.Cells[1].Value.ToString();
            String apellido = dgvDocente.CurrentRow.Cells[2].Value.ToString();
            String dui = dgvDocente.CurrentRow.Cells[3].Value.ToString();
            String genero = dgvDocente.CurrentRow.Cells[4].Value.ToString();
            String nacimiento = dgvDocente.CurrentRow.Cells[5].Value.ToString();
            string idDireccion = dgvDocente.CurrentRow.Cells[6].Value.ToString();
            string recidencia = dgvDocente.CurrentRow.Cells[7].Value.ToString();
            string municipio = dgvDocente.CurrentRow.Cells[8].Value.ToString();
            string departamento = dgvDocente.CurrentRow.Cells[9].Value.ToString();
            String telefono = dgvDocente.CurrentRow.Cells[10].Value.ToString();
            String email = dgvDocente.CurrentRow.Cells[11].Value.ToString();
            string activo = dgvDocente.CurrentRow.Cells[12].Value.ToString();
            fechaRegistro = dgvDocente.CurrentRow.Cells[13].Value.ToString();
           



            txtIdDocente.Text = idDocente;
            txtNombreDocente.Text = Nombre;
            txtApellidoDocente.Text = apellido;
            txtDui.Text = dui;
            txtGenero.Text = genero;
            dtpFecha.Text = nacimiento;
            txtIdDireccion.Text = idDireccion;
            txtRecidencia.Text = recidencia;
            txtMunicipio.Text = municipio;
            txtDepartamento.Text = departamento;
            txtEmail.Text = email;
            txtTelefono.Text = telefono;



            if (activo == "1")
            {
                rbSi.Checked = true;
            }
            else
            {

                rbNo.Checked = false;

            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Carga();
        }
    }
}
