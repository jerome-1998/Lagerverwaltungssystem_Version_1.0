﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hausarbeit_Lager
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LagerverwaltungContext : DbContext
    {
        public LagerverwaltungContext()
            : base("name=LagerverwaltungContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BenutzerProfil> BenutzerProfil { get; set; }
        public virtual DbSet<KAnsprechpartner> KAnsprechpartner { get; set; }
        public virtual DbSet<Kunde> Kunde { get; set; }
        public virtual DbSet<LagerSystem> LagerSystem { get; set; }
        public virtual DbSet<LAnsprechpartner> LAnsprechpartner { get; set; }
        public virtual DbSet<Lieferer> Lieferer { get; set; }
        public virtual DbSet<Produkte> Produkte { get; set; }
        public virtual DbSet<Waren> Waren { get; set; }
        public virtual DbSet<Warenausgang> Warenausgang { get; set; }
        public virtual DbSet<Wareneingang> Wareneingang { get; set; }
    }
}
