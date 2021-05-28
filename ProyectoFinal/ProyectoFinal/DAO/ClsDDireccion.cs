using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.MODEL;
namespace ProyectoFinal.DAO
{
    class ClsDDireccion
    {

        public List<Direccion> cargarDatoUserList()

        {
            List<Direccion> Lista;

            using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
            {
                Lista = db.Direccion.ToList();


            }

            return Lista;
        }


        public void SaveDatosUser(Direccion user)
        {
            try
            {
                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {

                    Direccion direccion = new Direccion();

                    direccion.residencia = user.residencia;
                    direccion.municipio = user.municipio;
                    direccion.departamento = user.departamento;
                  
                    

                    db.Direccion.Add(direccion);
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
                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {
                    int eliminar = Convert.ToInt32(ID);
                    Direccion direccion = db.Direccion.Where(x => x.direccionId == eliminar).Select(x => x).FirstOrDefault();


                    db.Direccion.Remove(direccion);
                    db.SaveChanges();


                }
            }
            catch (Exception ex)
            {

            }
        }

        public void ModificarDocente(Direccion direccion)
        {
            try
            {


                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {

                    int update = Convert.ToInt32(direccion.direccionId);
                    Direccion userList = db.Direccion.Where(x => x.direccionId == update).Select(x => x).FirstOrDefault();


                    direccion.residencia = direccion.residencia;
                    direccion.municipio = direccion.municipio;
                    direccion.departamento = direccion.departamento;



                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }
        }


    }
}
