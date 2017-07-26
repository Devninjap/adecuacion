using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DATOS.accesoDatos;

namespace NEGOCIO
{
    public class blEstudiante : iOperaciones<estudiante>
    {
        public bool actualizar(estudiante entidad)
        {
            throw new NotImplementedException();
        }

        public estudiante consultar(int id)
        {
            return new daEstudiante().consultar(id);
        }

        public bool eliminar(int id)
        {
            return new daEstudiante().eliminar(id);
        }

        public List<estudiante> listarTodos()
        {
            return new daEstudiante().listarTodos();
        }

        public bool registrar(estudiante entidad)
        {
            return new daEstudiante().registrar(entidad);
        }
    }
}
