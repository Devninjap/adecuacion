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

        public ActionResult EstudianteActualizar(int id)
        {
            var operaciones = new claseOperaciones();
            operaciones.pEstudiante = new NEGOCIO.blEstudiante().consultar(id);
            return View(operaciones);
            //return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult EstudianteModificar(estudiante entidad)
        {
            est.actualizar(entidad);
            return RedirectToAction("EstudianteListar", "Estudiante");
        }
    }
}