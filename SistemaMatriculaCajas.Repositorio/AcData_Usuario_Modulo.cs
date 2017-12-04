using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatriculaCajas.Entidades;

namespace SistemaMatriculaCajas.Repositorio
{
    public class AcData_Usuario_Modulo : iOperaciones<USUARIO_MODULO>
    {
        public bool actualizar(USUARIO_MODULO entidad)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    USUARIO_MODULO usuario_modulo = contexto.USUARIO_MODULO.SingleOrDefault(x => x.Cod_USM == entidad.Cod_USM);
                    usuario_modulo.Cod_Usuario = entidad.Cod_Usuario;
                    usuario_modulo.Cod_Modulo = entidad.Cod_Modulo;
                    usuario_modulo.Cod_USM = entidad.Cod_USM;
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public USUARIO_MODULO consultar(int cod)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    return contexto.USUARIO_MODULO.SingleOrDefault(x => x.Cod_USM == cod);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminar(int cod)
        {
            throw new NotImplementedException();
        }

        public List<USUARIO_MODULO> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public bool registrar(USUARIO_MODULO entidad)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    contexto.USUARIO_MODULO.Add(entidad);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
