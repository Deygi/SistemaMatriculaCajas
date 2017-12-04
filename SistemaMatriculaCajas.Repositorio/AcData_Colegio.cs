using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatriculaCajas.Entidades;

namespace SistemaMatriculaCajas.Repositorio
{
    public class AcData_Colegio : iOperaciones<COLEGIO>
    {
        public bool actualizar(COLEGIO entidad)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    COLEGIO colegio = contexto.COLEGIO.SingleOrDefault(x => x.Cod_Colegio == entidad.Cod_Colegio);
                    colegio.Cod_Colegio = entidad.Cod_Colegio;
                    colegio.Nom_Colegio = entidad.Nom_Colegio;
                    colegio.Cod_Distrito = entidad.Cod_Distrito;
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public COLEGIO consultar(int cod)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    return contexto.COLEGIO.SingleOrDefault(x => x.Cod_Colegio == cod);
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

        public List<COLEGIO> ListarTodos()
        {
            using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
            {
                return contexto.COLEGIO.ToList();
            }
        }

        public bool registrar(COLEGIO entidad)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    contexto.COLEGIO.Add(entidad);
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
