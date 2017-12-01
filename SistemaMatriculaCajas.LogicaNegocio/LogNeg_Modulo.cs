using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatriculaCajas.Entidades;
using SistemaMatriculaCajas.Repositorio;

namespace SistemaMatriculaCajas.LogicaNegocio
{
    public class LogNeg_Modulo : iOperaciones<MODULO>
    {
        public bool actualizar(MODULO entidad)
        {
            return new AcData_Modulo().actualizar(entidad);
        }

        public MODULO consultar(int cod)
        {
            return new AcData_Modulo().consultar(cod);
        }

        public bool eliminar(int cod)
        {
            throw new NotImplementedException();
        }

        public List<MODULO> ListarTodos()
        {
            return new AcData_Modulo().ListarTodos();
        }

        public bool registrar(MODULO entidad)
        {
            return new AcData_Modulo().registrar(entidad);
        }
    }
}
