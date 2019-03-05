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
    public class ContratoController : Controller
    {
        //**********************************//
        //      CÓDIGO CONTRATO             //
        //**********************************//

        public ActionResult ContratoIndex()
        {
            ViewBag.ListaContrato = ContratoData.ListContrato();
            return View();
        }

        public ActionResult ContratoEdita(string numContrato)
        {

            Contrato contrato = ContratoData.traerContrato(int.Parse(numContrato));
            if (contrato == null)
            {
                HttpNotFound();
            }
            return View(contrato);
        }

        [HttpPost]
        public ActionResult CreaContrato([Bind(Include = "NumContrato,FechaInicio,FechaFinal,NombreEmpresa")] Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                ContratoData.CreaContrato(contrato);
                return RedirectToAction("ContratoIndex");
            }

            return View(contrato);
        }

        [HttpPost]
        public ActionResult EditarContrato(Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                ContratoData.EditaContrato(contrato);
            }
            return RedirectToAction("ContratoIndex");
        }

        //**********************************//
        //    TERMINA CÓDIGO CONTRATO       //
        //**********************************// 
    }
}