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
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.USUARIO_MODULO = new HashSet<USUARIO_MODULO>();
        }
    
        public int Cod_Usuario { get; set; }
        public string Nom_Usuario { get; set; }
        public string Apll_Paterno { get; set; }
        public string Apll_Materno { get; set; }
        public string Dni_Usuario { get; set; }
        public string Pass_Usuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO_MODULO> USUARIO_MODULO { get; set; }
    }
}
