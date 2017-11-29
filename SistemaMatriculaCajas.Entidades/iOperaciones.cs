using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatriculaCajas.Entidades
{
   public interface iOperaciones <T>
    {
        List<T> ListarTodos();

        bool registrar(T entidad);
        T consultar(int cod);
        bool actualizar(T entidad);
        bool eliminar(int cod);
    }
}
