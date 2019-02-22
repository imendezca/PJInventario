using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PJInventario.Models;
using System.Data.Entity;
using PJInventario.Data;

namespace PJInventario.Controllers
{
    public class AdminController : Controller
    {
       
        
        // GET: Admin
        public ActionResult AdminIndex()
        {
            return View();
        }
        // GET: Despacho
        public ActionResult DespachoIndex()
        {
           return View (DespachoData.ListDespacho()); 
        }

        public ActionResult DespachoCrear()
        {
            ViewBag.CodCircuito = DespachoData.ExtraeNombreCircuito();
            return View();
        }

        // GET: TipoEquipo
        public ActionResult TipoEquipoIndex()
        {
            ViewBag.ListaTipoEquipo = TipoEquipoData.ListTipoEquipo();
            return View();
        }
    }
}