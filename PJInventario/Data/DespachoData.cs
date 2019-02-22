using PJInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace PJInventario.Data
{
    public class DespachoData
    {
        static PJInventarioEntities db = new PJInventarioEntities();

        public static List<Despacho> ListDespacho()
        {
            var despacho = db.Despacho.Include(d => d.Circuito);
            return despacho.ToList();
        }

        public static SelectList ExtraeNombreCircuito()
        {
            SelectList NombreCircuito = new SelectList(db.Circuito, "CodCircuito", "NombreCircuito");
            return (NombreCircuito);
        }

    }
}