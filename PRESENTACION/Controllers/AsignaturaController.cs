using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRESENTACION.Controllers
{
    public class AsignaturaController : Controller
    {
        NEGOCIO.blEquivalenciaAsignatura asg = new NEGOCIO.blEquivalenciaAsignatura();
        // GET: Asignaturas y Equivalencias
        public ActionResult AsignaturasListar()
        {
            var model = asg.listarTodos();
            return View(model);
        }
    }
}