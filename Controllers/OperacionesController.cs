using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using Lab03_Mvc_Valverde_B.Models;//se pone como refernecia siemrpe  


namespace Lab03_Mvc_Valverde_B.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularOperaciones(ClsOperaciones objOperacion)
        {
            if (objOperacion.tipo == "S")
            {
                objOperacion.resultado=objOperacion.valor1 + objOperacion.valor2;

            }
            if (objOperacion.tipo == "R")
            {
                objOperacion.resultado = objOperacion.valor1 + objOperacion.valor2;
            }
            if (objOperacion.tipo == "M")
            {
                objOperacion.resultado = objOperacion.valor1 * objOperacion.valor2;
            }
            if (objOperacion.tipo == "D")
            {
                objOperacion.resultado = objOperacion.valor1 / objOperacion.valor2;
            }
            return View(objOperacion);


        }

    }
}