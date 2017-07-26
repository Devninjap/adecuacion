using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRESENTACION.Controllers
{
    public class ProcesoController : Controller
    {
        // GET: Proceso
        public ActionResult ProcesoIndex(int id)
        {
            var operaciones = new claseOperaciones();
            operaciones.pEstudiante = new NEGOCIO.blEstudiante().consultar(id);
            operaciones.pEquivalencias = new NEGOCIO.blEquivalenciaAsignatura().listarTodos();
            return View(operaciones);
        }
    }
}