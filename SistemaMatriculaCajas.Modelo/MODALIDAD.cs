//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaMatriculaCajas.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class MODALIDAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MODALIDAD()
        {
            this.POSTULANTE = new HashSet<POSTULANTE>();
        }
    
        public string Cod_Modalidad { get; set; }
        public string Nom_Modalidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POSTULANTE> POSTULANTE { get; set; }
    }
}
