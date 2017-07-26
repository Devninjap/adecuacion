using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DATOS.accesoDatos;

namespace NEGOCIO
{
    public class blDetalleAdecuacion : iOperaciones<detalleAdecuacion>
    {
        public bool actualizar(detalleAdecuacion entidad)
        {
            throw new NotImplementedException();
        }

        public detalleAdecuacion consultar(int id)
        {
            return new daDetalleAdecuacion().consultar(id);
        }

        public bool eliminar(int id)
        {
            return new daDetalleAdecuacion().eliminar(id);
        }

        public List<detalleAdecuacion> listarTodos()
        {
            return new daDetalleAdecuacion().listarTodos();
        }

        public bool registrar(detalleAdecuacion entidad)
        {
            return new daDetalleAdecuacion().registrar(entidad);
        }
    }
}
