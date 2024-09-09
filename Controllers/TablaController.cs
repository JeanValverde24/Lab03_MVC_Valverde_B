using Lab03_Mvc_Valverde_B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03_Mvc_Valverde_B.Controllers
{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GenerarTabla(ClsTabla objTabla)
        {
            return View(objTabla);
        }

    }
}