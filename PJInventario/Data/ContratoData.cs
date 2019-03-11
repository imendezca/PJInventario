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

        public static Contrato traerContrato(int numContrato)
        {
            using (PJInventarioEntities database = new PJInventarioEntities())
            {
                Contrato econtratoARetornar = database.Contrato.Find(numContrato);
                return econtratoARetornar;
            }
        }

        public static Contrato CreaContrato(Contrato contrato)
        {
            db.sp_Crea_Contrato(contrato.NumContrato, contrato.FechaInicio, contrato.FechaFinal, contrato.NombreEmpresa);
            return contrato;
        }

        public static void EditaContrato(Contrato contrato)
        {
            try
            {
                db.sp_Edita_Contrato(contrato.NumContrato, contrato.FechaInicio, contrato.FechaFinal, contrato.NombreEmpresa);
            }
            catch(Exception ex)
            {
                SqlException sqlex = ex.InnerException as SqlException;
            }
        }
    }
}