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
            using(PJInventarioEntities database = new PJInventarioEntities())
            {
                var listaTipoEquipo = from valor in database.TipoEquipo
                                      select valor;
                return listaTipoEquipo.ToList();
            }
        }

        public static void agregaTipoEquipo (TipoEquipo tipoEquipoNuevo)
        {
            db.sp_Crea_TipoEquipo(tipoEquipoNuevo.Nombre);
        }

        public static TipoEquipo traerTipoEquipo(int idTipoEquipoAEditar)
        {
            using (PJInventarioEntities database = new PJInventarioEntities())
            {
                TipoEquipo equipoARetornar = database.TipoEquipo.Find(idTipoEquipoAEditar);
                return equipoARetornar;
            }
        }

        public static void modificaTipoEquipo(TipoEquipo tipoEquipoNuevo)
        {
            db.sp_Edita_TipoEquipo(tipoEquipoNuevo.IDTipoEquipo, tipoEquipoNuevo.Nombre);
        }
    }
}