using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatriculaCajas.Entidades;

namespace SistemaMatriculaCajas.Repositorio
{
    public class AcData_Distrito : iOperaciones<DISTRITO>
    {
        public bool actualizar(DISTRITO entidad)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    DISTRITO distrito = contexto.DISTRITO.SingleOrDefault(x => x.Cod_Distrito == entidad.Cod_Distrito);
                    distrito.Cod_Distrito = entidad.Cod_Distrito;
                    distrito.Nom_Distrito = entidad.Nom_Distrito;
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public DISTRITO consultar(int cod)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    return contexto.DISTRITO.SingleOrDefault(x => x.Cod_Distrito == cod);

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

        public List<DISTRITO> ListarTodos()
        {
            using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
            {
               return contexto.DISTRITO.ToList();
            }
        }

        public bool registrar(DISTRITO entidad)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    contexto.DISTRITO.Add(entidad);
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
