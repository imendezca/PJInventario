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
    }
}