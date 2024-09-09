using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab03_Mvc_Valverde_B.Models;



namespace Lab03_Mvc_Valverde_B.Controllers
{
    public class CompraController : Controller
    {
        // GET: Compra
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularCompra(ClsVentaAleatoria objVenta)
        {
            Random rand = new Random();

            objVenta.random=rand.Next(1, 500);

            return View(objVenta);
        }
    }
}