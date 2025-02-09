﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartHotel.Registration.Web.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class smarthotelEntities : DbContext
    {
        public smarthotelEntities()
            : base("name=smarthotelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<LnkRoleAction> LnkRoleActions { get; set; }
        public virtual DbSet<LnkRoleAttribute> LnkRoleAttributes { get; set; }
        public virtual DbSet<LnkUserComponent> LnkUserComponents { get; set; }
        public virtual DbSet<LnkUserInfoRole> LnkUserInfoRoles { get; set; }
    
        public virtual int crossuserinfo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("crossuserinfo");
        }
    
        public virtual ObjectResult<Linkroute_Result> Linkroute()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Linkroute_Result>("Linkroute");
        }
    
        public virtual ObjectResult<LinkUser_Result> LinkUser()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LinkUser_Result>("LinkUser");
        }
    
        public virtual int NewProc(string uRL, string blobCREDENTIALName, Nullable<int> blockSizeBit)
        {
            var uRLParameter = uRL != null ?
                new ObjectParameter("URL", uRL) :
                new ObjectParameter("URL", typeof(string));
    
            var blobCREDENTIALNameParameter = blobCREDENTIALName != null ?
                new ObjectParameter("BlobCREDENTIALName", blobCREDENTIALName) :
                new ObjectParameter("BlobCREDENTIALName", typeof(string));
    
            var blockSizeBitParameter = blockSizeBit.HasValue ?
                new ObjectParameter("BlockSizeBit", blockSizeBit) :
                new ObjectParameter("BlockSizeBit", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("NewProc", uRLParameter, blobCREDENTIALNameParameter, blockSizeBitParameter);
        }
    
        public virtual int Proc_FileStream()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_FileStream");
        }
    
        public virtual int Proc_FileStreamTest()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_FileStreamTest");
        }
    
        public virtual int Proc_Revoke()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Revoke");
        }
    }
}
