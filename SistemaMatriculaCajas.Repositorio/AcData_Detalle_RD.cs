using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatriculaCajas.Entidades;

namespace SistemaMatriculaCajas.Repositorio
{
    public class AcData_Detalle_RD : iOperaciones<DETALLE_RD>
    {
        public bool actualizar(DETALLE_RD entidad)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    DETALLE_RD detalleRD = contexto.DETALLE_RD.SingleOrDefault(x => x.Cod_Detalle_RD == entidad.Cod_Detalle_RD);
                    detalleRD.Cod_Detalle_RD = entidad.Cod_Detalle_RD;
                    detalleRD.Tipo_RD = entidad.Tipo_RD;
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public DETALLE_RD consultar(int cod)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    return contexto.DETALLE_RD.SingleOrDefault(x => x.Cod_Detalle_RD == cod);
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

        public List<DETALLE_RD> ListarTodos()
        {
            using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
            {
                return contexto.DETALLE_RD.ToList();
            }
        }

        public bool registrar(DETALLE_RD entidad)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    contexto.DETALLE_RD.Add(entidad);
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
