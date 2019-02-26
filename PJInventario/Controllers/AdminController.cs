﻿using System;
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
        public ActionResult CreaTipoEquipo(TipoEquipo despacho)
        {
            if (ModelState.IsValid)
            {
                TipoEquipoData.agregaTipoEquipo(despacho);
                return RedirectToAction("TipoEquipoIndex");
            }
            return View("TipoEquipoIndex");
        }

        //**********************************//
        //  TERMINA CÓDIGO TIPO DE EQUIPO   //
        //**********************************//


        //
        //CÓDIGO DESPACHO
        //
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

        
        public ActionResult EditaDespacho([Bind(Include ="CodDespacho")]Despacho despacho)
        {
            if (despacho.CodDespacho==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           
            if (despacho == null)
            {
                return HttpNotFound();
            }            
            return View(DespachoData.solicitaEdicion(despacho.CodDespacho));
        }

        //FIN CÓDIGO DESPACHO
        //
    }
}