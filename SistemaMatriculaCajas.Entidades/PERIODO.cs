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
    
    public partial class PERIODO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERIODO()
        {
            this.MATRICULA = new HashSet<MATRICULA>();
            this.POSTULANTE = new HashSet<POSTULANTE>();
        }
    
        public int Cod_Periodo { get; set; }
        public System.DateTime Ini_Semestre { get; set; }
        public System.DateTime Fin_Semestre { get; set; }
        public System.DateTime Recuperacion { get; set; }
        public System.DateTime Ini_Matricula { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MATRICULA> MATRICULA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POSTULANTE> POSTULANTE { get; set; }
    }
}
