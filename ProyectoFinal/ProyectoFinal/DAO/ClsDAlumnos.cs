using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.MODEL;
namespace ProyectoFinal.DAO
{
    class ClsDAlumnos
    {


        public List<Alumno> cargarAlumno ()

        {
            List<Alumno> Lista;

            using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
            {
                Lista = db.Alumno.ToList();


            }

            return Lista;
        }


        public void SaveAlumno(Alumno alumno)
        {
            try
            {
                using (AdministracionEscolarEntities db = new  AdministracionEscolarEntities())
                {

                    Alumno alumno1 = new Alumno();

                    alumno1.nombre = alumno.nombre;
                    alumno1.apellidoPaterno = alumno.apellidoPaterno;
                    alumno1.apellidoMaterno = alumno.apellidoMaterno;
                    alumno1.genero = alumno.genero;
                    alumno1.fechaNacimiento = alumno.fechaNacimiento;
                    alumno1.direccionFk = alumno.direccionFk;
                    alumno1.contacto = alumno.contacto;
                    alumno1.correo = alumno.correo;
                    alumno1.activo = alumno.activo;
                    alumno1.fechaRegistro = alumno.fechaRegistro;
                    alumno1.encargadoFK = alumno.encargadoFK;

                    db.Alumno.Add(alumno1);
                    db.SaveChanges();



                }

            }
            catch (Exception ex)
            {

            }
        }

        public void deleteAlumno(int ID)
        {
            try
            {
                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities ())
                {
                    int eliminar = Convert.ToInt32(ID);
                    Alumno alumnoList = db.Alumno.Where(x => x.alumnoId == eliminar).Select(x => x).FirstOrDefault();


                    db.Alumno.Remove(alumnoList);
                    db.SaveChanges();


                }
            }
            catch (Exception ex)
            {

            }
        }
        public void ModificarAlunmos(Alumno alumno)
        {
            try
            {


                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {

                    int update = Convert.ToInt32(alumno.alumnoId); 
                    Alumno alumnoUpdate = db.Alumno.Where(x => x.alumnoId == update).Select(x => x).FirstOrDefault();


                    alumnoUpdate.nombre = alumno.nombre;
                    alumnoUpdate.apellidoPaterno = alumno.apellidoPaterno;
                    alumnoUpdate.apellidoMaterno = alumno.apellidoMaterno;
                    alumnoUpdate.genero = alumno.genero;
                    alumnoUpdate.fechaNacimiento = alumno.fechaNacimiento;
                    alumnoUpdate.direccionFk = alumno.direccionFk;
                    alumnoUpdate.contacto = alumno.contacto;
                    alumnoUpdate.correo = alumno.correo;
                    alumnoUpdate.activo = alumno.activo;
                    alumnoUpdate.fechaRegistro = alumno.fechaRegistro;
                    db.SaveChanges();
                }

            }
            catch (Exception ex )
            {
                System.Windows.Forms.MessageBox.Show("Error" + ex);
            }
        }


    }
}
