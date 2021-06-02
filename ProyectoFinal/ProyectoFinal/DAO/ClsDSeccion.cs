using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.MODEL;

namespace ProyectoFinal.DAO
{
    class ClsDSeccion
    {
        public List<Seccion> cargarSeccion()

        {
            List<Seccion> Lista;

            using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
            {
                Lista = db.Seccion.ToList();


            }

            return Lista;
        }
    }
}
