using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRESENTACION.Controllers
{
    public class ReporteController : Controller
    {
        // GET: Reporte
        public ActionResult ReporteIndex()
        {
            var Model = new NEGOCIO.blDetalleAdecuacion().listarTodos();
            return View(Model);
        }

		public ActionResult reporte()
		{
			return View();
		}
	}
}