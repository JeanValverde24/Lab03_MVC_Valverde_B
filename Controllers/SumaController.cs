using Lab03_Mvc_Valverde_B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03_Mvc_Valverde_B.Controllers
{
    public class SumaController : Controller
    {
        // GET: Suma
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcularSuma()
        {
            //isntnaciiando la clases  
            ClsSuma objSuma = new ClsSuma(); 

            // obteniendo los parametros d el  formulario html 
            objSuma.valor1 = Convert.ToDouble(Request.Form["numero1"]);

            objSuma.valor2 = Convert.ToDouble(Request.Form["numero2"]);

            //calculo de la operacion  

            objSuma.resultado = objSuma.valor1 + objSuma.valor2;

            return View(objSuma);
        }
    }
}