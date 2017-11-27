using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatriculaCajas.Entidades;
namespace SistemaMatriculaCajas.Repositorio
{
    public class AcData_Carrera_Profesional : iOperaciones<CARRERA_PROFESIONAL>
    {
        public bool actualizar(CARRERA_PROFESIONAL entidad)
        {
            throw new NotImplementedException();
        }

        public CARRERA_PROFESIONAL consultar(string cod)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto=new SistemaMatriculaCajasEntities())
                {
                    return contexto.CARRERA_PROFESIONAL.SingleOrDefault(x => x.Cod_CarreraP == cod);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminar(string cod)
        {
            throw new NotImplementedException();
        }

        public List<CARRERA_PROFESIONAL> ListarTodos()
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto=new SistemaMatriculaCajasEntities())
                {
                    return contexto.CARRERA_PROFESIONAL.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool registrar(CARRERA_PROFESIONAL entidad)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto= new SistemaMatriculaCajasEntities () )
                {
                    contexto.CARRERA_PROFESIONAL.Add(entidad);
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
