﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SistemaMatriculaCajasEntities : DbContext
    {
        public SistemaMatriculaCajasEntities()
            : base("name=SistemaMatriculaCajasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CARRERA_PROFESIONAL> CARRERA_PROFESIONAL { get; set; }
        public virtual DbSet<COLEGIO> COLEGIO { get; set; }
        public virtual DbSet<CURSO> CURSO { get; set; }
        public virtual DbSet<DEPARTAMENTO> DEPARTAMENTO { get; set; }
        public virtual DbSet<DISTRITO> DISTRITO { get; set; }
        public virtual DbSet<DOCENTE> DOCENTE { get; set; }
        public virtual DbSet<DOCENTE_CURSO> DOCENTE_CURSO { get; set; }
        public virtual DbSet<ESTUDIANTE> ESTUDIANTE { get; set; }
        public virtual DbSet<EXAMEN> EXAMEN { get; set; }
        public virtual DbSet<HORARIO> HORARIO { get; set; }
        public virtual DbSet<MATRICULA> MATRICULA { get; set; }
        public virtual DbSet<MODALIDAD> MODALIDAD { get; set; }
        public virtual DbSet<NOTAS> NOTAS { get; set; }
        public virtual DbSet<PERIODO> PERIODO { get; set; }
        public virtual DbSet<PERSONA> PERSONA { get; set; }
        public virtual DbSet<POSTULANTE> POSTULANTE { get; set; }
        public virtual DbSet<PROVINCIA> PROVINCIA { get; set; }
        public virtual DbSet<SALON> SALON { get; set; }
    }
}
