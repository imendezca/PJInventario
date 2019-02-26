using PJInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PJInventario.Data
{
    public class TipoEquipoData
    {
        static PJInventarioEntities db = new PJInventarioEntities();

        public static List<TipoEquipo> ListTipoEquipo()
        {
            var listaTipoEquipo= db.TipoEquipo;
            return listaTipoEquipo.ToList();
        }

        public static void agregaTipoEquipo (TipoEquipo tipoEquipoNuevo)
        {
            db.sp_Crea_TipoEquipo(tipoEquipoNuevo.Nombre);
        }
    }
}