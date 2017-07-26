using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DATOS.accesoDatos
{
    public class daDetalleAdecuacion : iOperaciones<detalleAdecuacion>
    {
        public bool actualizar(detalleAdecuacion entidad)
        {
            throw new NotImplementedException();
        }

        public detalleAdecuacion consultar(int id)
        {
            try
            {
                using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
                {
                    return ctx.detalleAdecuacion.SingleOrDefault(x => x.idDetalle == id);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public List<detalleAdecuacion> listarTodos()
        {
            try
            {
                using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
                {
                    return ctx.detalleAdecuacion.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool registrar(detalleAdecuacion entidad)
        {
            try
            {
                using (adecuacionIscFiuplaEntities ctx = new adecuacionIscFiuplaEntities())
                {
                    ctx.detalleAdecuacion.Add(entidad);
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
    }
}
