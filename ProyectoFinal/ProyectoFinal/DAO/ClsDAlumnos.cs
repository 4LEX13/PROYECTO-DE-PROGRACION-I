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


        public List<Alumnos> cargarDatoUserList()

        {
            List<Alumnos> Lista;

            using (GestorEstudiantesEntities db = new GestorEstudiantesEntities())
            {
                Lista = db.Alumnos.ToList();


            }

            return Lista;
        }


        public void SaveDatosUser(Alumnos user)
        {
            try
            {
                using (GestorEstudiantesEntities db = new GestorEstudiantesEntities())
                {

                    Alumnos userList = new Alumnos();

                    userList.nombre = user.nombre;
                    userList.Apellidos = user.Apellidos;
                    userList.dirreccion = user.dirreccion;
                    userList.representante = user.representante;
                    userList.nacimiento = user.nacimiento;
                    userList.contacto1 = user.contacto1;
                    userList.correo = user.correo;

                    db.Alumnos.Add(userList);
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
                using (GestorEstudiantesEntities db = new GestorEstudiantesEntities())
                {
                    int eliminar = Convert.ToInt32(ID);
                    Alumnos userList = db.Alumnos.Where(x => x.alumnoid == eliminar).Select(x => x).FirstOrDefault();


                    db.Alumnos.Remove(userList);
                    db.SaveChanges();


                }
            }
            catch (Exception ex)
            {

            }
        }
        public void ModificarAlunmos(Alumnos user)
        {
            try
            {


                using (GestorEstudiantesEntities db = new GestorEstudiantesEntities())
                {

                    int update = Convert.ToInt32(user.alumnoid);
                    Alumnos userList = db.Alumnos.Where(x => x.alumnoid == update).Select(x => x).FirstOrDefault();


                    userList.nombre = user.nombre;
                    userList.Apellidos = user.Apellidos;
                    userList.dirreccion = user.dirreccion;
                    userList.representante= user.representante;
                    userList.nacimiento = user.nacimiento;
                    userList.contacto1 = user.contacto1;
                    userList.correo = user.correo;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }
        }


    }
}
