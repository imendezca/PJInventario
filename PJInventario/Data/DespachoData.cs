using PJInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PJInventario.Data
{
    public class DespachoData
    {
    static PJInventarioEntities db = new PJInventarioEntities();

        public static List<Despacho> ListDespacho ()
        {
            var despacho = db.Despacho.Include(d => d.Circuito);
            return despacho.ToList();
        }
    }
}