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

        public List<Maestro> cargarAlumno()

        {
            List<Alumno> Lista = new List<Alumno>();

            using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
            {
                Lista = db.Alumno.ToList();

            }

            return Lista;
        }

        public void SaveAlumno(Alumno Alumno)
        {
            try
            {
                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {

                    Alumno AlumnoSave = new Alumno();

                    AlumnoSave.nombre = Alumno.nombre;
                    AlumnoSave.apellidoPaterno = Alumno.apellidoPaterno;
                    AlumnoSave.apellidoMaterno = Alumno.apellidoMaterno;
                    AlumnoSave.genero = Alumno.genero;
                    AlumnoSave.fechaNacimiento = Alumno.fechaNacimiento;
                    AlumnoSave.direccionFk = Alumno.direccionFk;
                    AlumnoSave.contacto = Alumno.contacto;
                    AlumnoSave.correo = Alumno.correo;
                    AlumnoSave.activo = Alumno.activo;
                    AlumnoSave.fechaRegistro = Alumno.fechaRegistro;

                    db.Alumno.Add(AlumnoSave);
                    db.SaveChanges();



                }

            }
            catch (Exception ex)
            {

            }
        }

        public void deleteAlumnoe(int ID)
        {
            try
            {
                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {
                    int eliminar = Convert.ToInt32(ID);
                    Alumno userList = db.Alumno.Where(x => x.alumnoId == eliminar).Select(x => x).FirstOrDefault();


                    db.Alumno.Remove(userList);
                    db.SaveChanges();


                }
            }
            catch (Exception ex)
            {

            }
        }

        public void ModificarDocente(Alumno Alumno)
        {
            try
            {


                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {

                    int update = Convert.ToInt32(Alumno.alumnoId);
                    Maestro Alumnoupdate = db.Maestro.Where(x => x.maestroId == update).Select(x => x).FirstOrDefault();


                    Alumnoupdate.nombre = maestro.nombre;
                    Alumnoupdate.apellido = maestro.apellido;
                    Alumnoupdate.identificacion = maestro.identificacion;
                    Alumnoupdate.genero = maestro.genero;
                    Alumnoupdate.fechaNacimiento = maestro.fechaNacimiento;
                    Alumnoupdate.direccionFk = maestro.direccionFk;
                    Alumnoupdate.contacto = maestro.contacto;
                    Alumnoupdate.correo = maestro.correo;
                    Alumnoupdate.activo = maestro.activo;
                    Alumnoupdate.fechaRegistro = maestro.fechaRegistro;


                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }
        }


    }
}
