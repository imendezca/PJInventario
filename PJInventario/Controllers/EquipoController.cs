using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PJInventario.Models;
using System.Data.Entity;


namespace PJInventario.Controllers
{
    public class EquipoController : Controller
    {
        private PJInventarioEntities db = new PJInventarioEntities();
        // GET: Equipo
        public ActionResult EquipoIndex()
        {
            var equipo = db.Equipo.Include(e => e.Contrato).Include(e => e.Estado).Include(e => e.Puesto_Despacho).Include(e => e.TipoEquipo);
            return View(equipo.ToList());
        }

        public ActionResult CreaEquipo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreaEquipo([Bind(Include = "Activo,NumSerie,Marca,Descripcion,TipoDeEquipo,CodDespacho,IDPuesto,NumContrato,IDEstado,Alquilado,FechaIngreso,Observaciones,UsuarioCrea,UsuarioModifica,UltimaModicacion")]Equipo equipo)
        {
            

            return View();
        }
    }
}