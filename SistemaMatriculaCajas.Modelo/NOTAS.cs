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
    
    public partial class NOTAS
    {
        public int Cod_Nota { get; set; }
        public int Nota_Semestre { get; set; }
        public int Nota_Recuperacion { get; set; }
        public string Obsv { get; set; }
        public string Cod_Curso { get; set; }
        public int Cod_Docente_Curso { get; set; }
        public string Cod_Matricula { get; set; }
    
        public virtual CURSO CURSO { get; set; }
        public virtual DOCENTE_CURSO DOCENTE_CURSO { get; set; }
        public virtual MATRICULA MATRICULA { get; set; }
    }
}
