﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AP_PRO_Balladins_2_annee
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ConnexionDb : DbContext
    {
        public ConnexionDb()
            : base("name=ConnexionDb")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<chambre> chambre { get; set; }
        public virtual DbSet<equipement> equipement { get; set; }
        public virtual DbSet<hotel> hotel { get; set; }
        public virtual DbSet<photo> photo { get; set; }
        public virtual DbSet<reserv> reserv { get; set; }
        public virtual DbSet<reservation> reservation { get; set; }
    }
}
