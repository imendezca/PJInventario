//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PJInventario.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Puesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Puesto()
        {
            this.Puesto_Despacho = new HashSet<Puesto_Despacho>();
        }
    
        public string IDPuesto { get; set; }
        public string NombrePuesto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Puesto_Despacho> Puesto_Despacho { get; set; }
    }
}