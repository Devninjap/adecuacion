using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public interface iOperaciones <T>
    {
        List<T> listarTodos();
        bool registrar(T entidad);
        T consultar(int id);
        bool actualizar(T entidad);
        bool eliminar(int id);
    }
}
