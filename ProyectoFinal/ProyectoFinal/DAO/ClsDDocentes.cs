using ProyectoFinal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DAO
{
    class ClsDDocentes
    {

        public List<Docente> cargarDatoUserList()

        {
            List<Docente> Lista;

            using (GestorEstudiantesEntities db = new GestorEstudiantesEntities())
            {
                Lista = db.Docente.ToList();


            }

            return Lista;
        }

        public void SaveDatosUser(Docente user)
        {
            try
            {
                using (GestorEstudiantesEntities db = new GestorEstudiantesEntities())
                {

                    Docente userList = new Docente();

                    userList.nombre = user.nombre;
                    userList.apellido = user.apellido;
                    userList.dirreccion = user.dirreccion;
                    userList.dui = user.dui;
                    userList.nacimiento = user.nacimiento;
                    userList.email = user.email;
                    userList.telefono = user.telefono;

                    db.Docente.Add(userList);
                    db.SaveChanges();



                }

            }
            catch (Exception ex)
            {

            }
        }

        public void deleteDocente(int ID)
        {
            try
            {
                using (GestorEstudiantesEntities db = new GestorEstudiantesEntities())
                {
                    int eliminar = Convert.ToInt32(ID);
                    Docente userList = db.Docente.Where(x => x.docenteid == eliminar).Select(x => x).FirstOrDefault();


                    db.Docente.Remove(userList);
                    db.SaveChanges();


                }
            }
            catch (Exception ex)
            {

            }
        }

        public void ModificarDocente(Docente user)
        {
            try
            {


                using (GestorEstudiantesEntities db = new GestorEstudiantesEntities())
                {

                    int update = Convert.ToInt32(user.docenteid);
                    Docente userList = db.Docente.Where(x => x.docenteid == update).Select(x => x).FirstOrDefault();


                    userList.nombre = user.nombre;
                    userList.apellido = user.apellido;
                    userList.dirreccion = user.dirreccion;
                    userList.dui = user.dui;
                    userList.nacimiento = user.nacimiento;
                    userList.email = user.email;
                    userList.telefono = user.telefono;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }
        }


    }
}
