using PJInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Net;

namespace PJInventario.Data
{
    public class DespachoData
    {
       static PJInventarioEntities db = new PJInventarioEntities();

        public static List<Despacho> ListDespacho()
        {
            using (PJInventarioEntities database = new PJInventarioEntities())
            {
                var despacho = database.Despacho.Include(d => d.Circuito);
                return despacho.ToList();
            } 
           
        }

        public static SelectList ExtraeNombreCircuito()
        {
            SelectList NombreCircuito = new SelectList(db.Circuito, "CodCircuito", "NombreCircuito");
            return (NombreCircuito);
        }

        public static Despacho CreaDespacho(Despacho despacho)
        {
           
            db.sp_Crea_Despacho(despacho.CodDespacho, despacho.CodCircuito, despacho.NombreDespacho, despacho.CantTecJud, despacho.CantTecJur, despacho.CantCoordJud, despacho.CantJuezCoord, despacho.CantJuezTram, despacho.CantJueces, despacho.CantOtros);
            return despacho;                       
        }

        public static Despacho solicitaEdicion(string id)
        {
            Despacho despacho = db.Despacho.Find(id);
            return (despacho);
        }
    }
}