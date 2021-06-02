using ProyectoFinal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                    encargadoSave.nombreEncargado = encargado.nombreEncargado;
                    encargadoSave.apellidoEncargado = encargado.apellidoEncargado;
                    encargadoSave.identificacionEncargado = encargado.identificacionEncargado;
                    encargadoSave.contactoEncargado = encargado.contactoEncargado;
                    encargadoSave.correoEncargado = encargado.correoEncargado;



                    db.Encargado.Add(encargadoSave);
                    db.SaveChanges();



                }

            }
            catch (Exception ex)
            {

            }
        }



        public void eliminarEncargado(int ID)
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

        public void modificarEncargado(Encargado encargado)
        {
            try
            {


                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {

                    int update = Convert.ToInt32(encargado.encargadoId);
                    Encargado encargado1 = db.Encargado.Where(x => x.encargadoId == update).Select(x => x).FirstOrDefault();

                    encargado1.nombreEncargado= encargado.nombreEncargado;
                    encargado1.apellidoEncargado = encargado.apellidoEncargado;
                    encargado1.identificacionEncargado = encargado.identificacionEncargado;
                    encargado1.contactoEncargado = encargado.contactoEncargado;
                    encargado1.correoEncargado = encargado.correoEncargado;



                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}

