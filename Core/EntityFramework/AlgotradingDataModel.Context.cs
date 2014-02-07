﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AlgorithmicTradingEntities : DbContext
    {
        public AlgorithmicTradingEntities()
            : base("name=AlgorithmicTradingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tick> Ticks { get; set; }
        public virtual DbSet<HistoricalStock> HistoricalStocks { get; set; }
        public virtual DbSet<Portfolio> Portfolios { get; set; }
        public virtual DbSet<Portfolio_Security> Portfolio_Security { get; set; }
        public virtual DbSet<Security> Securities { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual ObjectResult<SelectSymbolsByUser_Result> SelectSymbolsByUser(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectSymbolsByUser_Result>("SelectSymbolsByUser", userNameParameter);
        }
    }
}
