﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_eveh.BD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AERODROMOS> AERODROMOS { get; set; }
        public DbSet<AERONAVES> AERONAVES { get; set; }
        public DbSet<COMPONENTES> COMPONENTES { get; set; }
        public DbSet<DETALLES_MANTENIMIENTOS> DETALLES_MANTENIMIENTOS { get; set; }
        public DbSet<LICENCIAS> LICENCIAS { get; set; }
        public DbSet<MANTENIMIENTOS> MANTENIMIENTOS { get; set; }
        public DbSet<PERFILES_USUARIOS> PERFILES_USUARIOS { get; set; }
        public DbSet<PERSONAS> PERSONAS { get; set; }
        public DbSet<PILOTOS> PILOTOS { get; set; }
        public DbSet<PLANES> PLANES { get; set; }
        public DbSet<TIPOS_AERONAVES> TIPOS_AERONAVES { get; set; }
        public DbSet<TIPOS_COMPONENTES> TIPOS_COMPONENTES { get; set; }
        public DbSet<TIPOS_LICENCIAS> TIPOS_LICENCIAS { get; set; }
        public DbSet<TRIPULACION> TRIPULACION { get; set; }
        public DbSet<USUARIOS> USUARIOS { get; set; }
        public DbSet<VUELOS> VUELOS { get; set; }
    }
}