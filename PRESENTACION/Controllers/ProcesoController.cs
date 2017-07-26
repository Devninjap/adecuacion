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

        [HttpPost]
        public void ajax(detalleAdecuacion[] item)
        {
            NEGOCIO.blDetalleAdecuacion est = new NEGOCIO.blDetalleAdecuacion();
            for (int i = 0; i < item.Length; i++)
            {
                est.registrar(item[i]);
            }
        }

        [HttpPost]
        public int ajax_adecuacion(adecuacion item)
        {
            new NEGOCIO.blAdecuacion().registrar(item);
            int idAdecuacion = new NEGOCIO.blAdecuacion().listarTodos().FirstOrDefault(x => x.idEstudiante == item.idEstudiante).idAdecuacion;
            return idAdecuacion;
        }
    }
}