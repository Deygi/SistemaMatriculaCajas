﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatriculaCajas.Entidades;
using SistemaMatriculaCajas.Repositorio;

namespace SistemaMatriculaCajas.LogicaNegocio 
{
    public class LogNeg_Usuario : iOperaciones<USUARIO_MODULO>
    {
        public bool actualizar(USUARIO_MODULO entidad)
        {
            return new AcData_Usuario().actualizar(entidad);
        }

        public USUARIO_MODULO consultar(int cod)
        {
            return new AcData_Usuario().consultar(cod);
        }

        public USUARIO_MODULO consultar(string dni)
        {
            return new AcData_Usuario().consultar(dni);
        }

        public bool eliminar(int cod)
        {
            throw new NotImplementedException();
        }

        public List<USUARIO_MODULO> ListarTodos()
        {
            return new AcData_Usuario().ListarTodos();
        }

        public bool registrar(USUARIO_MODULO entidad)
        {
            return new AcData_Usuario().registrar(entidad);
        }
    }
}
