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
    public class AdminController : Controller
    {
       
        
        // GET: Admin
        public ActionResult AdminIndex()
        {
            return View();
        }

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
                TipoEquipoData.modificaTipoEquipo (tipoEquipo);
            }
            ViewBag.ListaTipoEquipo = TipoEquipoData.ListTipoEquipo();
            return View("TipoEquipoIndex");
        }

        //**********************************//
        //  TERMINA CÓDIGO TIPO DE EQUIPO   //
        //**********************************//


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
             var despacho=DespachoData.solicitaEdicion(id);
       
            if (despacho == null)
            {
                return HttpNotFound();
            }
            ViewBag.CodCircuito = DespachoData.ExtraeNombreCircuito();
            return View(despacho);
        }

        //**********************************//
        //    TERMINA CÓDIGO DESPACHO       //
        //**********************************//
    }
}