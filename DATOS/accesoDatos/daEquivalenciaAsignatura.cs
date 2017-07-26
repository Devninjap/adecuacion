using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DATOS.accesoDatos;

namespace DATOS.accesoDatos
{
    public class daEquivalenciaAsignatura : iOperaciones<equivalenciaAsignatura>
    {
        public bool actualizar(equivalenciaAsignatura entidad)
        {
            throw new NotImplementedException();
        }

        public equivalenciaAsignatura consultar(int id)
        {
            try
            {
                using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
                {
                    return ctx.equivalenciaAsignatura.SingleOrDefault(x => x.idEquivalencia == id);
                }
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public bool eliminar(int id)
        {
            try
            {
                using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
                {
                    ctx.equivalenciaAsignatura.Remove(ctx.equivalenciaAsignatura.SingleOrDefault(x=>x.idEquivalencia == id));
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

        public List<equivalenciaAsignatura> listarTodos()
        {
            try
            {
                using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
                {
                    return ctx.equivalenciaAsignatura.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool registrar(equivalenciaAsignatura entidad)
        {
            try
            {
                using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
                {
                    ctx.equivalenciaAsignatura.Add(entidad);
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
