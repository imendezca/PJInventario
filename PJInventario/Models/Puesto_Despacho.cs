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
    
    public partial class Puesto_Despacho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Puesto_Despacho()
        {
            this.Equipo = new HashSet<Equipo>();
        }
    
        public string CodDespacho { get; set; }
        public string IDPuesto { get; set; }
    
        public virtual Despacho Despacho { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipo> Equipo { get; set; }
        public virtual Puesto Puesto { get; set; }
    }
}