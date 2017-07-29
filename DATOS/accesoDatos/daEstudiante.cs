using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DATOS.accesoDatos
{
    public class daEstudiante : iOperaciones<estudiante>
    {
        public bool actualizar(estudiante entidad)
        {
            try
            {
                using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
                {
                    estudiante est = ctx.estudiante.SingleOrDefault(x => x.idEstudiante == entidad.idEstudiante);
                    est.codEstudiante = entidad.codEstudiante;
                    est.apellidosEstudiante = entidad.apellidosEstudiante;
                    est.nombresEstudiante = entidad.nombresEstudiante;
                    est.sede = entidad.sede;
                    est.modalidad = entidad.modalidad;
                    est.carrera = entidad.carrera;
                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public estudiante consultar(int id)
        {
            try
            {
                using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
                {
                    return ctx.estudiante.SingleOrDefault(x=>x.idEstudiante==id);
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
                    ctx.estudiante.Remove(ctx.estudiante.SingleOrDefault(x => x.idEstudiante == id));
                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<estudiante> listarTodos()
        {
            try
            {
                using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
                {
                    return ctx.estudiante.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool registrar(estudiante entidad)
        {
            try
            {
                using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
                {
                    ctx.estudiante.Add(entidad);
                    ctx.SaveChanges();
                    return true;
                }
                    
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
