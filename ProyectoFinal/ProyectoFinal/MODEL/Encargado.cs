//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinal.MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Encargado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Encargado()
        {
            this.Alumno = new HashSet<Alumno>();
        }
    
        public int encargadoId { get; set; }
        public string nombreEncargado { get; set; }
        public string apellidoEncargado { get; set; }
        public string identificacionEncargado { get; set; }
        public string contactoEncargado { get; set; }
        public string correoEncargado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alumno> Alumno { get; set; }
    }
}
