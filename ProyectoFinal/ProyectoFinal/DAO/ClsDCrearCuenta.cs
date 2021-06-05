using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.MODEL;
namespace ProyectoFinal.DAO
{
    class ClsDCrearCuenta
    {


        public List<Usuario> CargarUsuario()

        {
            List<Usuario> ListaUsuario;

            using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
            {
                ListaUsuario = db.Usuario.ToList();


            }

            return ListaUsuario;
        }


        public void GuardarCuenta(Usuario usuarios)
        {
            try
            {
                using (AdministracionEscolarEntities db = new AdministracionEscolarEntities())
                {

                    Usuario usuario = new Usuario();

                    usuario.correo_Usuario = usuarios.correo_Usuario;
                    usuario.contrasena = usuarios.contrasena;




                    db.Usuario.Add(usuario);
                    db.SaveChanges();



                }

            }
            catch (Exception ex)
            {

            }





        }
    }
}