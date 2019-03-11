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
    public class DespachoController : Controller
    {
        //**********************************//
        //      CÓDIGO DESPACHO             //
        //**********************************//
        // GET: Despacho
        public ActionResult DespachoIndex()
        {
            ViewBag.ListaDespacho = DespachoData.ListDespacho();
            ViewBag.CodCircuito = DespachoData.ExtraeNombreCircuito();
            return View();
        }

        [HttpPost]
        public ActionResult CreaDespacho([Bind(Include = "CodDespacho,CodCircuito,NombreDespacho,CantTecJud,CantTecJur,CantCoordJud,CantJuezCoord,CantJuezTram,CantJueces,CantOtros")] Despacho despacho)
        {
            if (ModelState.IsValid)
            {
                DespachoData.CreaDespacho(despacho);
                return RedirectToAction("DespachoIndex");
            }
            ViewBag.CodCircuito = DespachoData.ExtraeNombreCircuito();
            return View(despacho);
        }

        public ActionResult DespachoEdita(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var despacho = DespachoData.TraerDespacho(id);

            if (despacho == null)
            {
                return HttpNotFound();
            }
            ViewBag.CodCircuito = DespachoData.ExtraeNombreCircuito();
            return View(despacho);
        }

        [HttpPost]
        public ActionResult EditarDespacho(Despacho despacho)
        {
            if (ModelState.IsValid)
            {
                DespachoData.ModificaDespacho(despacho);
            }
            ViewBag.CodCircuito = DespachoData.ExtraeNombreCircuito();
            ViewBag.ListaDespacho = DespachoData.ListDespacho();
            return View("DespachoIndex");
        }

        //**********************************//
        //    TERMINA CÓDIGO DESPACHO       //
        //**********************************//
    }
}