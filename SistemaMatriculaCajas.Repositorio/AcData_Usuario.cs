using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatriculaCajas.Entidades;
namespace SistemaMatriculaCajas.Repositorio
{
    public class AcData_Usuario : iOperaciones<USUARIO>
    {
        public bool actualizar(USUARIO entidad)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto =new SistemaMatriculaCajasEntities())
                {
                    USUARIO usuario = contexto.USUARIO.SingleOrDefault(x => x.Cod_Usuario == entidad.Cod_Usuario);
                    usuario.Nom_Usuario = entidad.Nom_Usuario;
                    usuario.Apll_Paterno = entidad.Apll_Paterno;
                    usuario.Apll_Materno = entidad.Apll_Materno;
                    usuario.Dni_Usuario = entidad.Dni_Usuario;
                    usuario.Pass_Usuario = entidad.Pass_Usuario;
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        

        public USUARIO consultar(int cod)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    return contexto.USUARIO.SingleOrDefault(x => x.Cod_Usuario == cod);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public USUARIO consultar(string dni)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    return contexto.USUARIO.SingleOrDefault(x => x.Dni_Usuario == dni);
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

        public List<USUARIO> ListarTodos()
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    return contexto.USUARIO.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool registrar(USUARIO entidad)
        {
            try
            {
                using (SistemaMatriculaCajasEntities contexto = new SistemaMatriculaCajasEntities())
                {
                    contexto.USUARIO.Add(entidad);
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
