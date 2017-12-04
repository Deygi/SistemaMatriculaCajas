using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatriculaCajas.Entidades;
using SistemaMatriculaCajas.Repositorio;
namespace SistemaMatriculaCajas.LogicaNegocio
{
    public class LogNeg_Colegio : iOperaciones<COLEGIO>
    {
        public bool actualizar(COLEGIO entidad)
        {
            return new AcData_Colegio().actualizar(entidad);
        }

        public COLEGIO consultar(int cod)
        {
            return new AcData_Colegio().consultar(cod);
        }

        public bool eliminar(int cod)
        {
            throw new NotImplementedException();
        }

        public List<COLEGIO> ListarTodos()
        {
            return new AcData_Colegio().ListarTodos();
        }

        public bool registrar(COLEGIO entidad)
        {
            return new AcData_Colegio().registrar(entidad);
        }
    }
}
