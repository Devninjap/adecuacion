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
            var Model = new NEGOCIO.blAdecuacion().listarTodos();
            return View(Model);
        }

		public ActionResult Reporte(int id)
		{
            ENTIDADES.adecuacion model = new ENTIDADES.adecuacion { 
                idAdecuacion = id
            };
			return View(model);
		}
	}
}