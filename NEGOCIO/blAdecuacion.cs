using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DATOS.accesoDatos;

namespace NEGOCIO
{
    public class blAdecuacion : iOperaciones<adecuacion>
    {
        public bool actualizar(adecuacion entidad)
        {
            throw new NotImplementedException();
        }

        public adecuacion consultar(int id)
        {
            return new daAdecuacion().consultar(id);
        }

        public bool eliminar(int id)
        {
            return new daAdecuacion().eliminar(id);
        }

        public List<adecuacion> listarTodos()
        {
            return new daAdecuacion().listarTodos();
        }

        public bool registrar(adecuacion entidad)
        {
            return new daAdecuacion().registrar(entidad);
        }
    }
}
