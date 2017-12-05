using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatriculaCajas.Entidades;
using SistemaMatriculaCajas.Repositorio;

namespace SistemaMatriculaCajas.LogicaNegocio 
{
    public class LogNeg_Usuario : iOperaciones<USUARIO>
    {
        public bool actualizar(USUARIO entidad)
        {
            return new AcData_Usuario().actualizar(entidad);
        }

        public USUARIO consultar(int cod)
        {
            return new AcData_Usuario().consultar(cod);
        }

        public USUARIO consultar(string dni)
        {
            return new AcData_Usuario().consultar(dni);
        }

        public bool eliminar(int cod)
        {
            throw new NotImplementedException();
        }

        public List<USUARIO> ListarTodos()
        {
            return new AcData_Usuario().ListarTodos();
        }

        public bool registrar(USUARIO entidad)
        {
            return new AcData_Usuario().registrar(entidad);
        }
    }
}
