﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportSarfasl.dataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbAtiran2Entities : DbContext
    {
        public DbAtiran2Entities()
            : base("name=DbAtiran2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<act_zirsarfasls> act_zirsarfasls { get; set; }
        public virtual DbSet<sarfasls> sarfasls { get; set; }
        public virtual DbSet<zirsarfasls> zirsarfasls { get; set; }
    }
}
