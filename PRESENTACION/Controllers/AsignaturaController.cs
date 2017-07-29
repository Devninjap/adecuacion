using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ENTIDADES;

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

        public ActionResult AsignaturaRegistrar()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult AsignaturaNuevo(equivalenciaAsignatura entidad)
        {
            asg.registrar(entidad);
            return RedirectToAction("AsignaturasListar", "Asignatura");
        }
    }
}