﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CentroDeCorreos.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MDCSynergiaEntities3 : DbContext
    {
        public MDCSynergiaEntities3()
            : base("name=MDCSynergiaEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCorreosElectronicosPruebas> tblCorreosElectronicosPruebas { get; set; }
        public virtual DbSet<tblUsuarioSynergia> tblUsuarioSynergia { get; set; }
        public virtual DbSet<tblUsuarioSynergiaRelCatFranquicia> tblUsuarioSynergiaRelCatFranquicia { get; set; }
        public virtual DbSet<tblAdjuntosCorreoPruebas> tblAdjuntosCorreoPruebas { get; set; }
    }
}