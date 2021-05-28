using ProyectoFinal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DAO
{
    class ClsDMaestro
    {
        public List<Maestro> cargarMaestros()

        {
            List<Maestro> Lista = new List<Maestro>();

            using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
            {
                Lista = db.Maestro.ToList();

            }

            return Lista;
        }

        public void SaveDatosUser(Maestro maestro)
        {
            try
            {
                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {

                    Maestro maestroSave = new Maestro();

                    maestroSave.nombre = maestro.nombre;
                    maestroSave.apellido = maestro.apellido;
                    maestroSave.identificacion = maestro.identificacion;
                    maestroSave.genero = maestro.genero;
                    maestroSave.fechaNacimiento = maestro.fechaNacimiento;
                    maestroSave.direccionFk = maestro.direccionFk;
                    maestroSave.contacto = maestro.contacto;
                    maestroSave.correo = maestro.correo;
                    maestroSave.activo = maestro.activo;
                    maestroSave.fechaRegistro = maestro.fechaRegistro;

                    db.Maestro.Add(maestroSave);
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
                    Maestro userList = db.Maestro.Where(x => x.maestroId == eliminar).Select(x => x).FirstOrDefault();


                    db.Maestro.Remove(userList);
                    db.SaveChanges();


                }
            }
            catch (Exception ex)
            {

            }
        }

        public void ModificarDocente(Maestro maestro)
        {
            try
            {


                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {

                    int update = Convert.ToInt32(maestro.maestroId);
                    Maestro maestroupdate = db.Maestro.Where(x => x.maestroId == update).Select(x => x).FirstOrDefault();


                    maestroupdate.nombre = maestro.nombre;
                    maestroupdate.apellido = maestro.apellido;
                    maestroupdate.identificacion = maestro.identificacion;
                    maestroupdate.genero = maestro.genero;
                    maestroupdate.fechaNacimiento = maestro.fechaNacimiento;
                    maestroupdate.direccionFk = maestro.direccionFk;
                    maestroupdate.contacto = maestro.contacto;
                    maestroupdate.correo = maestro.correo;
                    maestroupdate.activo = maestro.activo;
                    maestroupdate.fechaRegistro = maestro.fechaRegistro;


                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }
        }


    }
}
