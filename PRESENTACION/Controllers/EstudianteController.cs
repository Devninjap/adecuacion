using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ENTIDADES;
using System.Threading.Tasks;

namespace PRESENTACION.Controllers
{
    public class EstudianteController : Controller
    {
        NEGOCIO.blEstudiante est = new NEGOCIO.blEstudiante();
        // GET: Estudiante
        public ActionResult EstudianteListar()
        {
            var model = est.listarTodos();
            return View(model);
        }

        public ActionResult EstudianteRegistrar()
        {
            return View();
        }



        [HttpPost]
        [AllowAnonymous]
        public ActionResult EstudianteNuevo(estudiante estd)
        {
            est.registrar(estd);
            return RedirectToAction("EstudianteListar","Estudiante");
        }

        //[HttpPost]
        //[AllowAnonymous]
        //public ActionResult EstudianteNuevo(estudiante estd)
        //{
        //    est.registrar(estd);
        //    return View();
        //}
    }
}