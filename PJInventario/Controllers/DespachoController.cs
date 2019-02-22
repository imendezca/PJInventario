using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PJInventario.Models;
using System.Data.Entity;

namespace PJInventario.Controllers
{
    public class DespachoController : Controller
    {
        PJInventarioEntities db = new PJInventarioEntities();
        // GET: Despacho
        public ActionResult DespachoIndex()
        {
            var despacho = db.Despacho.Include(d => d.Circuito);
            return View(despacho.ToList());
        }
    }
}