﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCProje.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbStokEntities1 : DbContext
    {
        public DbStokEntities1()
            : base("name=DbStokEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblKategorıler> TblKategorıler { get; set; }
        public virtual DbSet<TblMusterıler> TblMusterıler { get; set; }
        public virtual DbSet<TblSatıs> TblSatıs { get; set; }
        public virtual DbSet<TblUrunler> TblUrunler { get; set; }
    }
}
