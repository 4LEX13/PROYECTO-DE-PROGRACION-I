using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.MODEL;

namespace ProyectoFinal.DAO
{
    class ClsDGrado
    {
        public List<Grado> cargarGrados()

        {
            List<Grado> Lista;

            using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
            {
                Lista = db.Grado.ToList();


            }

            return Lista;
        }
    }
}
