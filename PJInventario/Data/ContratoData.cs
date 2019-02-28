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
    public class ContratoData
    {
        static PJInventarioEntities db = new PJInventarioEntities();

        public static List<Contrato> ListContrato()
        {
            using (PJInventarioEntities database = new PJInventarioEntities())
            {
                var contrato = database.Contrato.ToList();
                return contrato.ToList();
            }
        }

        public static Contrato CreaContrato(Contrato contrato)
        {
            db.sp_Crea_Contrato(contrato.NumContrato, contrato.FechaInicio, contrato.FechaFinal, contrato.NombreEmpresa);
            return contrato;
        }
    }
}