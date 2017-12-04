using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatriculaCajas.Entidades;
using SistemaMatriculaCajas.Repositorio;


namespace SistemaMatriculaCajas.LogicaNegocio
{
    class LogNeg_Carrera_Profesional : iOperaciones<CARRERA_PROFESIONAL>
    {
        public bool actualizar(CARRERA_PROFESIONAL entidad)
        {
            return new AcData_Carrera_Profesional().actualizar(entidad);
        }

        public CARRERA_PROFESIONAL consultar(int cod)
        {
            return new AcData_Carrera_Profesional().consultar(cod);
        }

        public bool eliminar(int cod)
        {
            throw new NotImplementedException();
        }

        public List<CARRERA_PROFESIONAL> ListarTodos()
        {
            return new AcData_Carrera_Profesional().ListarTodos();
        }

        public bool registrar(CARRERA_PROFESIONAL entidad)
        {
            return new AcData_Carrera_Profesional().registrar(entidad);
        }
    }
}
