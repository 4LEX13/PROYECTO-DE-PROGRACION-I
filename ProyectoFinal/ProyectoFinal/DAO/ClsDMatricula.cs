using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.MODEL;

namespace ProyectoFinal.DAO
{
    class ClsDMatricula
    {
        public List<Matricula> cargarMatricula()

        {
            List<Matricula> Lista = new List<Matricula>();

            using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
            {
                Lista = db.Matricula.ToList();

            }

            return Lista;
        }

        public void guardarMatricula(Matricula matricula)
        {
            try
            {
                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {

                    Matricula matriculaGuardar = new Matricula();

                    matriculaGuardar.alumnoFk = matricula.alumnoFk;
                    matriculaGuardar.gradoFk = matricula.gradoFk;
                    matriculaGuardar.seccionFk = matricula.seccionFk;
                    matriculaGuardar.nombreMatricula = matricula.nombreMatricula;
                    matriculaGuardar.fechaRegistroMatricula = matricula.fechaRegistroMatricula;

                    db.Matricula.Add(matriculaGuardar);
                    db.SaveChanges();



                }

            }
            catch (Exception ex)
            {

            }
        }

        public void eliminarMatricula(int ID)
        {
            try
            {
                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {
                    int eliminar = Convert.ToInt32(ID);
                    Matricula matricula = db.Matricula.Where(x => x.matriculaId == eliminar).Select(x => x).FirstOrDefault();


                    db.Matricula.Remove(matricula);
                    db.SaveChanges();


                }
            }
            catch (Exception ex)
            {

            }
        }

        public void modificarMatricula(Matricula matricula)
        {
            try
            {


                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {

                    int update = Convert.ToInt32(matricula.matriculaId);
                    Matricula cambiarMatricula = db.Matricula.Where(x => x.matriculaId == update).Select(x => x).FirstOrDefault();


                    cambiarMatricula.alumnoFk = matricula.alumnoFk;
                    cambiarMatricula.gradoFk = matricula.gradoFk;
                    cambiarMatricula.seccionFk = matricula.seccionFk;
                    cambiarMatricula.nombreMatricula = matricula.nombreMatricula;
                    //cambiarMatricula.fechaRegistro = matricula.fechaRegistro;


                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
