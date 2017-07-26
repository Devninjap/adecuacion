using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DATOS.accesoDatos;

namespace NEGOCIO
{
    public class blEquivalenciaAsignatura : iOperaciones<equivalenciaAsignatura>
    {
        public bool actualizar(equivalenciaAsignatura entidad)
        {
            throw new NotImplementedException();
        }

        public equivalenciaAsignatura consultar(int id)
        {
            return new daEquivalenciaAsignatura().consultar(id);
        }

        public bool eliminar(int id)
        {
            return new daEquivalenciaAsignatura().eliminar(id);
        }

        public List<equivalenciaAsignatura> listarTodos()
        {
            return new daEquivalenciaAsignatura().listarTodos();
        }

        public bool registrar(equivalenciaAsignatura entidad)
        {
            return new daEquivalenciaAsignatura().registrar(entidad);
        }
    }
}
