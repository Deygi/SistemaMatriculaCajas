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
    
    public partial class DOCENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOCENTE()
        {
            this.DOCENTE_CURSO = new HashSet<DOCENTE_CURSO>();
        }
    
        public int Cod_Docente { get; set; }
        public string Apll_Paterno { get; set; }
        public string Apll_Materno { get; set; }
        public string Nom { get; set; }
        public string Grado_Docente { get; set; }
        public string Correo { get; set; }
        public string CarreraP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCENTE_CURSO> DOCENTE_CURSO { get; set; }
    }
}
