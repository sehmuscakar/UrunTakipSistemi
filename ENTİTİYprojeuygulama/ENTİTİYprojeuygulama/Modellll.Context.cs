﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENTİTİYprojeuygulama
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbEntitiyUrunEntities1 : DbContext
    {
        public dbEntitiyUrunEntities1()
            : base("name=dbEntitiyUrunEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblkategori> tblkategori { get; set; }
        public virtual DbSet<tblmusteri> tblmusteri { get; set; }
        public virtual DbSet<tblsatiş> tblsatiş { get; set; }
        public virtual DbSet<tblurun> tblurun { get; set; }
        public virtual DbSet<tbladmin> tbladmin { get; set; }
    
        public virtual ObjectResult<string> markagetir()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("markagetir");
        }
    
        public virtual ObjectResult<string> markagetirsin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("markagetirsin");
        }
    }
}
