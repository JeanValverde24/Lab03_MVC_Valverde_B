using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab03_Mvc_Valverde_B.Models;

namespace Lab03_Mvc_Valverde_B.Controllers
{
    public class SumaRazorController : Controller
    {
        // GET: SumaRazor
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularSuma(ClsSuma objSuma)
        {

            objSuma.resultado = objSuma.valor1 + objSuma.valor2;

            return View(objSuma);
        }
    }
}