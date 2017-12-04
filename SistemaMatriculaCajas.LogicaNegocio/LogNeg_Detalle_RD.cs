using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatriculaCajas.Entidades;
using SistemaMatriculaCajas.Repositorio;

namespace SistemaMatriculaCajas.LogicaNegocio
{
    public class LogNeg_Detalle_RD : iOperaciones<DETALLE_RD>
    {
        public bool actualizar(DETALLE_RD entidad)
        {
            return new AcData_Detalle_RD().actualizar(entidad);
        }

        public DETALLE_RD consultar(int cod)
        {
            return new AcData_Detalle_RD().consultar(cod);
        }

        public bool eliminar(int cod)
        {
            throw new NotImplementedException();
        }

        public List<DETALLE_RD> ListarTodos()
        {
            return new AcData_Detalle_RD().ListarTodos();
        }

        public bool registrar(DETALLE_RD entidad)
        {
            return new AcData_Detalle_RD().registrar(entidad);
        }
    }
}
