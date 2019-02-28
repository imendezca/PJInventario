using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PJInventario.Models;
using System.Data.Entity;
using PJInventario.Data;
using System.Net;

namespace PJInventario.Controllers
{
    public class TipoEquipoController : Controller
    {
        //**********************************//
        //      CÓDIGO TIPO DE EQUIPO       //
        //**********************************//

        // GET: TipoEquipo
        public ActionResult TipoEquipoIndex()
        {
            ViewBag.ListaTipoEquipo = TipoEquipoData.ListTipoEquipo();
            return View();
        }

        [HttpPost]
        public ActionResult CreaTipoEquipo(TipoEquipo nuevoTipoEquipo)
        {
            if (ModelState.IsValid)
            {
                TipoEquipoData.agregaTipoEquipo(nuevoTipoEquipo);
                return RedirectToAction("TipoEquipoIndex");
            }
            return View("TipoEquipoIndex");
        }

        public ActionResult TipoEquipoEdita(string idTipoEquipo)
        {

            TipoEquipo tipoEquipo = TipoEquipoData.traerTipoEquipo(int.Parse(idTipoEquipo));
            if (tipoEquipo == null)
            {
                HttpNotFound();
            }
            return View(tipoEquipo);
        }

        [HttpPost]
        public ActionResult EditarTipoEquipo(TipoEquipo tipoEquipo)
        {
            if (ModelState.IsValid)
            {
                TipoEquipoData.modificaTipoEquipo(tipoEquipo);
            }
            ViewBag.ListaTipoEquipo = TipoEquipoData.ListTipoEquipo();
            return View("TipoEquipoIndex");
        }

        //**********************************//
        //  TERMINA CÓDIGO TIPO DE EQUIPO   //
        //**********************************//
    }
}