using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatriculaCajas.Entidades;

namespace SistemaMatriculaCajas.Repositorio
{
    public class AcData_Departamento : iOperaciones<DEPARTAMENTO>
    {
        public bool actualizar(DEPARTAMENTO entidad)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    DEPARTAMENTO departamento = contexto.DEPARTAMENTO.SingleOrDefault(x => x.Cod_Dept == entidad.Cod_Dept);
                    departamento.Cod_Dept = entidad.Cod_Dept;
                    departamento.Nom_Dept = entidad.Nom_Dept;
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public DEPARTAMENTO consultar(int cod)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    return contexto.DEPARTAMENTO.SingleOrDefault(x => x.Cod_Dept == cod);

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

        public List<DEPARTAMENTO> ListarTodos()
        {
            using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
            {
                return contexto.DEPARTAMENTO.ToList();
            }
        }

        public bool registrar(DEPARTAMENTO entidad)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    contexto.DEPARTAMENTO.Add(entidad);
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
