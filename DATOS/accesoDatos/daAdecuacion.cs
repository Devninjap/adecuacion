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
    }
}
