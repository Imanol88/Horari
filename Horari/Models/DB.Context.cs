﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Horari.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class horariEntities : DbContext
    {
        public horariEntities()
            : base("name=horariEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<asignatura> asignatura { get; set; }
        public virtual DbSet<asignaturacarrera> asignaturacarrera { get; set; }
        public virtual DbSet<carrera> carrera { get; set; }
        public virtual DbSet<carrerarevoe> carrerarevoe { get; set; }
        public virtual DbSet<cuatrimestre> cuatrimestre { get; set; }
        public virtual DbSet<curso> curso { get; set; }
        public virtual DbSet<disponibilidad> disponibilidad { get; set; }
        public virtual DbSet<grupo> grupo { get; set; }
        public virtual DbSet<hora> hora { get; set; }
        public virtual DbSet<horario> horario { get; set; }
        public virtual DbSet<profesor> profesor { get; set; }
        public virtual DbSet<revoe> revoe { get; set; }
        public virtual DbSet<semana> semana { get; set; }
        public virtual DbSet<tipocarrera> tipocarrera { get; set; }
        public virtual DbSet<turno> turno { get; set; }
    }
}
