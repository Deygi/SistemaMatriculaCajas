using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatriculaCajas.Entidades;

namespace SistemaMatriculaCajas.Repositorio
{
    public class AcData_Modulo : iOperaciones<MODULO>
    {
        public bool actualizar(MODULO entidad)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    MODULO modulo = contexto.MODULO.SingleOrDefault(x => x.Cod_Modulo == entidad.Cod_Modulo);
                    modulo.Cod_Modulo = entidad.Cod_Modulo;
                    modulo.Nom_Modulo = entidad.Nom_Modulo;
                    modulo.Descripcion = entidad.Descripcion;
                    modulo.USUARIO_MODULO = entidad.USUARIO_MODULO;
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public MODULO consultar(int cod)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    return contexto.MODULO.SingleOrDefault(x => x.Cod_Modulo == cod);
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

        public List<MODULO> ListarTodos()
        {
            using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
            {
                return contexto.MODULO.ToList();
            }
        }

        public bool registrar(MODULO entidad)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    contexto.MODULO.Add(entidad);
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
