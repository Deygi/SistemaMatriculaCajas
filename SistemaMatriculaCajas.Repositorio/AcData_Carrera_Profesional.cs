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
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    CARRERA_PROFESIONAL carrera_profesional = contexto.CARRERA_PROFESIONAL.SingleOrDefault(x => x.Cod_CarreraP == entidad.Cod_CarreraP);
                    carrera_profesional.Abrv_CarreraP = entidad.Abrv_CarreraP;
                    carrera_profesional.Cant_Semestre = entidad.Cant_Semestre;
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public CARRERA_PROFESIONAL consultar(int cod)
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

        public bool eliminar(int cod)
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
