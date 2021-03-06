﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntertainerManagementSite.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EntertainerManagementEntities : DbContext
    {
        public EntertainerManagementEntities()
            : base("name=EntertainerManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Agency> Agencies { get; set; }
        public virtual DbSet<AgencyOffice> AgencyOffices { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<AgentContactInformation> AgentContactInformations { get; set; }
        public virtual DbSet<AgentEntertainerContract> AgentEntertainerContracts { get; set; }
        public virtual DbSet<EntertainerGroup> EntertainerGroups { get; set; }
        public virtual DbSet<EntertainerMember> EntertainerMembers { get; set; }
        public virtual DbSet<OfficeContactInformation> OfficeContactInformations { get; set; }
        public virtual DbSet<Style> Styles { get; set; }
        public virtual DbSet<agentEntertainer> agentEntertainers { get; set; }
        public virtual DbSet<AgentEntertainerGroup> AgentEntertainerGroups { get; set; }
    
        public virtual ObjectResult<GetAgentWithEntertainersByName_Result> GetAgentWithEntertainersByName(string fullNameParam)
        {
            var fullNameParamParameter = fullNameParam != null ?
                new ObjectParameter("fullNameParam", fullNameParam) :
                new ObjectParameter("fullNameParam", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAgentWithEntertainersByName_Result>("GetAgentWithEntertainersByName", fullNameParamParameter);
        }
    }
}
