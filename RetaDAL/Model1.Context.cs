﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RetaDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RetaDbEntities : DbContext
    {
        public RetaDbEntities()
            : base("name=RetaDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CUSTOMERADDRESS> CUSTOMERADDRESS { get; set; }
        public virtual DbSet<CUSTOMERS> CUSTOMERS { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }
        public virtual DbSet<STOCKS> STOCKS { get; set; }
    }
}
