//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaMatriculaCajas.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class CURSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CURSO()
        {
            this.HORARIO = new HashSet<HORARIO>();
        }
    
        public int Cod_Curso { get; set; }
        public string Nom_Curso { get; set; }
        public string Alias_Curso { get; set; }
        public int Cant_Crd { get; set; }
        public string Semestre { get; set; }
        public int Cod_CarreraP { get; set; }
    
        public virtual CARRERA_PROFESIONAL CARRERA_PROFESIONAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HORARIO> HORARIO { get; set; }
    }
}
