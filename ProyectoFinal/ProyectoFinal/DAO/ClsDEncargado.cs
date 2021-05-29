using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.MODEL;
namespace ProyectoFinal.DAO
{
    class ClsDEncargado
    {
        public List<Encargado> cargarEncargado()

        {
            List<Encargado> Lista;

            using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
            {
                Lista = db.Encargado.ToList();


            }

            return Lista;
        }


        public void SaveEncargado(Encargado encargado)
        {
            try
            {
                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {

                    Encargado encargadoSave = new Encargado();

                    encargadoSave.alumnoFk = encargado.alumnoFk;
                    encargadoSave.nombre = encargado.nombre;
                    encargadoSave.apellido = encargado.apellido;
                    encargadoSave.identificacion = encargado.identificacion;
                    encargadoSave.contacto = encargado.contacto;
                    encargadoSave.correo = encargado.correo;



                    db.Encargado.Add(encargadoSave);
                    db.SaveChanges();



                }

            }
            catch (Exception ex)
            {

            }
        }



        public void deleteDireccion(int ID)
        {
            try
            {
                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {
                    int eliminar = Convert.ToInt32(ID);
                    Encargado encargado = db.Encargado.Where(x => x.encargadoId == eliminar).Select(x => x).FirstOrDefault();


                    db.Encargado.Remove(encargado);
                    db.SaveChanges();


                }
            }
            catch (Exception ex)
            {

            }
        }

        public void ModificarDireccion(Encargado encargado)
        {
            try
            {


                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {

                    int update = Convert.ToInt32(encargado.encargadoId);
                    Encargado encargado1 = db.Encargado.Where(x => x.encargadoId == update).Select(x => x).FirstOrDefault();


                    encargado1.alumnoFk = encargado.alumnoFk;
                    encargado1.nombre = encargado.nombre;
                    encargado1.apellido = encargado.apellido;
                    encargado1.identificacion = encargado.identificacion;
                    encargado1.contacto = encargado.contacto;
                    encargado1.correo = encargado.correo;



                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
