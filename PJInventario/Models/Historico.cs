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
    
    public partial class Historico
    {
        public int Activo { get; set; }
        public string NumSerie { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public string TipoDeEquipo { get; set; }
        public string NombreDespacho { get; set; }
        public string NombrePuesto { get; set; }
        public int NumContrato { get; set; }
        public bool Alquilado { get; set; }
        public string Estado { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public string Observaciones { get; set; }
        public string UsuarioCrea { get; set; }
        public string UsuarioModifica { get; set; }
        public System.DateTime UltimaModificacion { get; set; }
    }
}
