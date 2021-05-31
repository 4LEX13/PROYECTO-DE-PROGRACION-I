﻿using System;
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
    public partial class FrmAlumos : Form
    {
        public FrmAlumos()
        {
            InitializeComponent();
            Carga();
            clear();
        }



        void clear()
        {

            txtIdAlumos.Clear();
            txtNombreAlumno.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtGenero.Clear();
            txtContacto.Clear();
            txtCorreo.Clear();
           dtpFecha.Value = DateTime.Now.Date;

        }

        void Carga()
        {

            dgvAlumnos.Rows.Clear();
            using (AdministracionEscolarEntities bd = new AdministracionEscolarEntities())
            {
                var Lista = (from alumno in bd.Alumno
                             from direccion in bd.Direccion
                             where alumno.direccionFk == direccion.direccionId 
                             select new
                             {
                                 alumno.alumnoId,
                                 alumno.nombre,
                                 alumno.apellidoPaterno,
                                 alumno.apellidoMaterno,
                                 alumno.genero,
                                 alumno.fechaNacimiento,
                                 direccion.direccionId,
                                 direccion.residencia,
                                 direccion.municipio,
                                 direccion.departamento,
                                 alumno.contacto,
                                 alumno.correo,
                                 alumno.activo,
                                 alumno.fechaRegistro


                             }).ToList();


                foreach (var listadoMaestro in Lista)
                {
                    dgvAlumnos.Rows.Add(listadoMaestro.alumnoId, listadoMaestro.nombre, listadoMaestro.apellidoPaterno, listadoMaestro.apellidoMaterno,
                        listadoMaestro.genero, listadoMaestro.fechaNacimiento, listadoMaestro.direccionId, listadoMaestro.residencia,
                        listadoMaestro.municipio, listadoMaestro.departamento, listadoMaestro.contacto,
                        listadoMaestro.correo, listadoMaestro.activo, listadoMaestro.fechaRegistro);
                }
            }
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            //ClsDAlumnos clsDUserList = new ClsDAlumnos();
            //Alumno userList = new Alumno();
            //userList.nombre = txtNombreAlumno.Text;
            //userList.Apellido = txtApellidoAlumno.Text;
            //userList.dirreccion = txtDireccion.Text;
            //userList.representante = txtRepresentante.Text;
            //userList.nacimiento = dtpFecha.Value;
            //userList.contacto1 = txtContacto.Text;
            //userList.correo = txtCorreo.Text;

            //clsDUserList.SaveDatosUser(userList);

            //Carga();
            //clear();
        }

        private void btnRegistarAlumnos_Click_1(object sender, EventArgs e)
        {
            //ClsDAlumnos clsDUserList = new ClsDAlumnos();
            //Alumno userList = new Alumno();
            //userList.nombre = txtNombreAlumno.Text;
            //userList.Apellidos = txtApellidoAlumno.Text;
            //userList.dirreccion = txtDireccion.Text;
            //userList.representante = txtRepresentante.Text;
            //userList.nacimiento = dtpFecha.Value;
            //userList.contacto1 = txtContacto.Text;
            //userList.correo = txtCorreo.Text;

            //clsDUserList.SaveDatosUser(userList);

            //Carga();
            //clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDAlumnos user = new ClsDAlumnos();
            user.deleteAlumno(Convert.ToInt32(txtIdAlumos.Text));

            Carga();
            clear();
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String idAlumnos = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
            String nombre = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
            String direccion = dgvAlumnos.CurrentRow.Cells[3].Value.ToString();
            String representante = dgvAlumnos.CurrentRow.Cells[4].Value.ToString();
            String nacimiento = dgvAlumnos.CurrentRow.Cells[5].Value.ToString();
            String contacto = dgvAlumnos.CurrentRow.Cells[5].Value.ToString();
            String correo = dgvAlumnos.CurrentRow.Cells[6].Value.ToString();


            txtIdAlumos.Text = idAlumnos;
            txtNombreAlumno.Text = nombre;
            txtApellidoPaterno.Text = Apellido;
            txtApellidoMaterno.Text = direccion;
            txtGenero.Text = representante;
            dtpFecha.Value = default;
            txtContacto.Text = contacto;
            txtCorreo.Text = correo;


        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String idAlumnos = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
            String nombre = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
            String direccion = dgvAlumnos.CurrentRow.Cells[3].Value.ToString();
            String representante = dgvAlumnos.CurrentRow.Cells[4].Value.ToString();
            String nacimiento = dgvAlumnos.CurrentRow.Cells[5].Value.ToString();
            String contacto = dgvAlumnos.CurrentRow.Cells[5].Value.ToString();
            String correo = dgvAlumnos.CurrentRow.Cells[6].Value.ToString();


            txtIdAlumos.Text = idAlumnos;
            txtNombreAlumno.Text = nombre;
            txtApellidoPaterno.Text = Apellido;
            txtApellidoMaterno.Text = direccion;
            txtGenero.Text = representante;
            txtContacto.Text = contacto;
            txtCorreo.Text = correo;


        }
    }
}