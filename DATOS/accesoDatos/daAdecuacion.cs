using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DATOS.accesoDatos
{
    public class daAdecuacion : iOperaciones<adecuacion>
    {
        public bool actualizar(adecuacion entidad)
        {
            throw new NotImplementedException();
        }

        public adecuacion consultar(int id)
        {
            try
            {
                using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
                {
                    return ctx.adecuacion.SingleOrDefault(x => x.idAdecuacion == id);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool eliminar(int id)
        {
            try
            {
                using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
                {
                    ctx.adecuacion.Remove(ctx.adecuacion.SingleOrDefault(x => x.idAdecuacion == id));
                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<adecuacion> listarTodos()
        {
            try
            {
                using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
                {
                    return ctx.adecuacion.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool registrar(adecuacion entidad)
        {
            try
            {
                using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
                {
                    ctx.adecuacion.Add(entidad);
                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

		public object consultaReporte(int idAdecuacion)
		{
			try
			{
				using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
				{
					return (from estudiante in ctx.estudiante
							from adecuacion in estudiante.adecuacion
							from equivalencias in ctx.equivalenciaAsignatura
							from detalles in adecuacion.detalleAdecuacion
							//from detalles2 in equivalencias.detalleAdecuacion
							where adecuacion.idAdecuacion == idAdecuacion
							select new
							{
								estudiante.apellidosEstudiante,
								estudiante.nombresEstudiante,
								estudiante.codEstudiante,
								estudiante.sede,
								estudiante.modalidad,
								estudiante.carrera,
								adecuacion.codigoAdecuacion,
								adecuacion.futAdecuacion,
								adecuacion.fechaRecepcion,
								adecuacion.periodo,
								adecuacion.fechaEmision,
								equivalencias.planAsignaturaB,
								equivalencias.codAsignaturaB,
								equivalencias.nomAsignaturaB,
								equivalencias.codAsignaturaA,
								equivalencias.creditosAsignaturaA,
								equivalencias.cicloAsignaturaA,
								equivalencias.nomAsignaturaA,
								detalles.notaAsignaturaA,
								detalles.notaAsignaturaB,
								detalles.fechaActa,
							}).ToList();
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
    }
}
