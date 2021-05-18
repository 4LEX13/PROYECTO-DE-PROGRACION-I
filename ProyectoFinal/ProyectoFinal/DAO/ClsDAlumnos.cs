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
                  

                    db.Alumnos.Add(userList);
                    db.SaveChanges();



                }

            }
            catch (Exception ex)
            {

            }
        }

    }
}
